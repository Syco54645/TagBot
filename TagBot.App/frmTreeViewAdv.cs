﻿using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tagbot.Service;
using Tagbot.Service.contracts;
using Tagbot.Service.models;
using TagBot.App.Properties;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class frmTreeViewAdv : Form
    {
        public frmMain frmMain;
        private TreeModel _model;
        public frmTreeViewAdv()
        {
            InitializeComponent();
        }

        private void frmTreeViewAdv_Load(object sender, EventArgs e)
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = Settings.Default.databaseLocation;
            string showDataJson = sqlite.getShow("2021-09-03");

            ShowSearchResponseContract showData = Utility.DeserializeObject<ShowSearchResponseContract>(showDataJson);
            populateMatchTags(showData);

            tvMatchFiles.BeginUpdate();
            PopulateTreeView();
            tvMatchFiles.EndUpdate();

            // setup handlers for drag drop
            tvMatchFiles.DragDrop += tvDirectoriesAdv_DragDrop;
            tvMatchFiles.DragOver += tvDirectoriesAdv_DragOver;
            tvMatchFiles.ItemDrag += tvDirectoriesAdv_ItemDrag;
            tvMatchFiles.NodeMouseDoubleClick += tvDirectoriesAdv_NodeMouseDoubleClick;
            tvMatchFiles.AllowDrop = true;
            lvMatchTags.ItemDrag += lvMatchTags_ItemDrag;
        }

        private void tvDirectoriesAdv_NodeMouseDoubleClick(object sender, TreeNodeAdvMouseEventArgs e)
        {
            if (e.Control is NodeTextBox)
                MessageBox.Show(e.Node.Tag.ToString());
        }

        private void tvDirectoriesAdv_ItemDrag(object sender, ItemDragEventArgs e)
        {
            tvMatchFiles.DoDragDropSelectedNodes(DragDropEffects.Move);
        }

        private void tvDirectoriesAdv_DragOver(object sender, DragEventArgs e)
        {
            /*if (e.Data.GetDataPresent(typeof(TreeNodeAdv[])) && tvMatchFiles.DropPosition.Node != null)
            {
                TreeNodeAdv[] nodes = e.Data.GetData(typeof(TreeNodeAdv[])) as TreeNodeAdv[];
                TreeNodeAdv parent = tvMatchFiles.DropPosition.Node;
                if (nodes.FirstOrDefault().Level == 2 && parent.Level == 2) // we have a child level drug in to a child leve so do not allow dragging
                {
                    e.Effect = DragDropEffects.None;
                }
                if (tvMatchFiles.DropPosition.Position != NodePosition.Inside)
                    parent = parent.Parent;

                foreach (TreeNodeAdv node in nodes)
                    if (!CheckNodeParent(parent, node))
                    {
                        e.Effect = DragDropEffects.None;
                        return;
                    }

                e.Effect = e.AllowedEffect;
            }
            else
            {

            }*/
            if (e.Data.GetDataPresent(typeof(TreeNodeAdv[])) && tvMatchFiles.DropPosition.Node != null)
            {
                TreeNodeAdv[] drugNodes = (TreeNodeAdv[])e.Data.GetData(typeof(TreeNodeAdv[]));
                TreeNodeAdv drugNode = drugNodes.FirstOrDefault();
                Point targetPoint = tvMatchFiles.PointToClient(new Point(e.X, e.Y));
                int targetNodeLevel = tvMatchFiles.GetNodeAt(targetPoint).Level;
                if (
                    (drugNode.Level == 1 && targetNodeLevel > 1) ||
                    (drugNode.Level == 1 && targetNodeLevel == 1 && tvMatchFiles.DropPosition.Position == NodePosition.Inside) ||
                    (drugNode.Level == 2 && targetNodeLevel == 1 && tvMatchFiles.DropPosition.Position != NodePosition.Inside) ||
                    (drugNode.Level == 2 && targetNodeLevel == 2 && tvMatchFiles.DropPosition.Position == NodePosition.Inside)
                   )
                {
                    e.Effect = DragDropEffects.None;
                    return;
                }
            }
            else if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
            {
                if (tvMatchFiles.DropPosition.Position != NodePosition.Inside)
                {
                    e.Effect = DragDropEffects.None;
                    return;
                }
            }
            e.Effect = e.AllowedEffect;
        }

        private void lvMatchTags_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(lvMatchTags.SelectedItems, DragDropEffects.Move);
        }

        private void tvDirectoriesAdv_DragDrop(object sender, DragEventArgs e)
        {
            tvMatchFiles.BeginUpdate();


            if (e.Data.GetDataPresent(typeof(TreeNodeAdv[])))
            {
                // dropping a node that already exists
                TreeNodeAdv[] drugNodes = (TreeNodeAdv[])e.Data.GetData(typeof(TreeNodeAdv[]));
                TreeNodeAdv drugNode = drugNodes.FirstOrDefault();
                Point targetPoint = tvMatchFiles.PointToClient(new Point(e.X, e.Y));
                Node targetNode = tvMatchFiles.DropPosition.Node.Tag as Node;
                int targetNodeLevel = tvMatchFiles.GetNodeAt(targetPoint).Level;
                // add a break point here to easily debug levels and drop positions for tuning the drag over event
                if (tvMatchFiles.DropPosition.Position == NodePosition.Inside)
                {
                    
                    if (drugNode.Level == 2 && targetNodeLevel == 2)
                    {
                        targetNode = targetNode.Parent;
                    }

                    if (drugNode.Level == 1 && targetNodeLevel == 1)
                    {
                        while (targetNode.Parent != null)
                        {
                            targetNode = targetNode.Parent;
                        }
                    }
                    (drugNode.Tag as Node).Parent = targetNode;
                    
                    //_model.Nodes[targetNode.Index].Nodes.Add(new Node(trackName));
                    tvMatchFiles.DropPosition.Node.IsExpanded = true;
                }
                else
                {
                    Node parent = targetNode.Parent;
                    Node nextItem = targetNode;
                    if (tvMatchFiles.DropPosition.Position == NodePosition.After)
                        nextItem = targetNode.NextNode;

                    foreach (TreeNodeAdv node in drugNodes)
                        (node.Tag as Node).Parent = null;

                    int index = -1;
                    index = parent.Nodes.IndexOf(nextItem);
                    foreach (TreeNodeAdv node in drugNodes)
                    {
                        Node item = node.Tag as Node;
                        if (index == -1)
                            parent.Nodes.Add(item);
                        else
                        {
                            parent.Nodes.Insert(index, item);
                            index++;
                        }
                    }
                }
            }
            else if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
            {

                Point targetPoint = tvMatchFiles.PointToClient(new Point(e.X, e.Y));
                TreeNodeAdv targetNode = tvMatchFiles.GetNodeAt(targetPoint);
                TreeNodeAdv tnNew;
                if (targetNode == null) return;

                while (targetNode.Level > 1)
                {
                    targetNode = targetNode.Parent;
                }

                ListView.SelectedListViewItemCollection lstViewColl = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection));
                foreach (ListViewItem lvItem in lstViewColl)
                {
                    Track track = (Track)lvItem.Tag;
                    string trackName = track.TrackName;
                    
                    targetNode.Expand();

                    // lvItem.Remove();
                    _model.Nodes[targetNode.Index].Nodes.Add(new Node(trackName));
                    lvItem.Font = new Font(lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Regular);
                    lvItem.ForeColor = Color.LightGray;
                }
            }
            tvMatchFiles.EndUpdate();
            //UpdateContention();
        }

        private void UpdateContention()
        {
            foreach (SongNode node in _model.Nodes)
            {
                //frmMain.proposedMetadata[node.Filename].Metadata.Title = node.
                string combinedTitle = string.Join(" > ", node.Nodes.Select(x => x.Text).ToArray());
                int trackNumber = node.Index + 1;
                frmMain.proposedMetadata[node.Filename].Metadata.Title = combinedTitle;
                frmMain.proposedMetadata[node.Filename].Metadata.Tracknumber = trackNumber.ToString();
                if (false) { }
            }
        }




        private void PopulateTreeView()
        {
            _model = new TreeModel();
            tvMatchFiles.Model = _model;
            
            foreach (KeyValuePair<string, FlacFileInfo> entry in frmMain.originalMetadata)
            {
                Node rootNode = AddRoot(entry.Key, entry.Value);
                if (false) { }
            }
            ResizeCols();
        }

        private void ResizeCols()
        {
            // taken from https://sourceforge.net/p/treeviewadv/discussion/568369/thread/b9e687fa/
            DrawContext _measureContext = new DrawContext();
            _measureContext.Graphics = Graphics.FromImage(new Bitmap(1, 1));
            _measureContext.Font = this.tvMatchFiles.Font;
            // On the first column take head for the plus/minus and lines. The 7 is the LeftMargin of the PlusMinus. 
            int newWidth = (this.tvMatchFiles.ShowPlusMinus ? 20 : 0) + 7;
            foreach (TreeColumn col in this.tvMatchFiles.Columns)
            {
                foreach (Aga.Controls.Tree.NodeControls.NodeControl nc in this.tvMatchFiles.NodeControls)
                {
                    if (nc.ParentColumn == col)
                    {
                        // Many controls can be displayed in the same column
                        int maxControlWidth = 0;
                        foreach (TreeNodeAdv tna in this.tvMatchFiles.AllNodes)
                        {
                            Size s = nc.MeasureSize(tna, _measureContext);
                            maxControlWidth = Math.Max(maxControlWidth, (s.Width + nc.LeftMargin));
                            if (false) { }
                        }
                        newWidth += maxControlWidth;
                    }
                }
                col.Width = newWidth;
                newWidth = 0;
            }
        }


        private Node AddRoot(string text, FlacFileInfo flacFileInfo)
        {
            SongNode node = new SongNode();
            node.Text = text;
            node.Filename = text;
            node.Image = frmMain.imgListFileIcons.Images["audio"];
            node.Artist = flacFileInfo.Metadata.Artist;
            node.Title = flacFileInfo.Metadata.Title;
            node.Tracknumber = flacFileInfo.Metadata.Tracknumber;
            _model.Nodes.Add(node);
            return node;
        }


        public class SongNode : Node
        {
            public string Filename { get; set; }
            public string Artist { get; set; }
            public string Title { get; set; }
            public string Tracknumber { get; set; }
        }




















        #region forklift
        public void populateMatchTags(ShowSearchResponseContract showData)
        {
            if (showData != null)
            {
                foreach (Track track in showData.Setlist)
                {
                    string format = "%n %t [%m]";
                    string formattedName = "";
                    if (String.IsNullOrEmpty(track.Modifier))
                    {
                        formattedName = string.Format("{0} - {1}", track.TrackNumber, track.TrackName);
                    }
                    else
                    {
                        formattedName = string.Format("{0} - {1} [{2}]", track.TrackNumber, track.TrackName, track.Modifier);
                    }
                    ListViewItem tempLVI = new ListViewItem(formattedName);
                    tempLVI.Tag = track;
                    tempLVI.Font = new Font(lvMatchTags.Font, FontStyle.Bold);
                    lvMatchTags.Items.Add(tempLVI);
                }
            }
            lvMatchTags.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMatchTags.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
       


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateContention();
        }
    }
}
