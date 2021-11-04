using Aga.Controls.Tree;
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

        private bool CheckNodeParent(TreeNodeAdv parent, TreeNodeAdv node)
        {
            while (parent != null)
            {
                if (node == parent)
                    return false;
                else
                    parent = parent.Parent;
            }
            return true;
        }

        private void tvDirectoriesAdv_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNodeAdv[])) && tvMatchFiles.DropPosition.Node != null)
            {
                TreeNodeAdv[] nodes = e.Data.GetData(typeof(TreeNodeAdv[])) as TreeNodeAdv[];
                TreeNodeAdv parent = tvMatchFiles.DropPosition.Node;
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
                e.Effect = e.AllowedEffect;

            }
        }

        private void lvMatchTags_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(lvMatchTags.SelectedItems, DragDropEffects.Move);
        }


        private void reorderFiles(object sender, DragEventArgs e)
        {

        }

        private void tvDirectoriesAdv_DragDrop(object sender, DragEventArgs e)
        {
            tvMatchFiles.BeginUpdate();


            if (e.Data.GetDataPresent(typeof(TreeNodeAdv[])))
            {
                reorderFiles(sender, e);
                TreeNodeAdv[] nodes = (TreeNodeAdv[])e.Data.GetData(typeof(TreeNodeAdv[]));
                Node dropNode = tvMatchFiles.DropPosition.Node.Tag as Node;
                if (tvMatchFiles.DropPosition.Position == NodePosition.Inside)
                {
                    while (dropNode.Parent != null)
                    {
                        dropNode = dropNode.Parent;
                    }
                    //return;
                    foreach (TreeNodeAdv n in nodes)
                    {
                        (n.Tag as Node).Parent = dropNode;
                    }
                    tvMatchFiles.DropPosition.Node.IsExpanded = true;
                }
                else
                {
                    Node parent = dropNode.Parent;
                    Node nextItem = dropNode;
                    if (tvMatchFiles.DropPosition.Position == NodePosition.After)
                        nextItem = dropNode.NextNode;

                    foreach (TreeNodeAdv node in nodes)
                        (node.Tag as Node).Parent = null;

                    int index = -1;
                    index = parent.Nodes.IndexOf(nextItem);
                    foreach (TreeNodeAdv node in nodes)
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
                    string trackName = lvItem.Text;
                    Track track = (Track)lvItem.Tag;
                    tnNew = new TreeNodeAdv(lvItem.Text);
                    //tnNew.Tag = track;

                    //targetNode.
                    //targetNode.Nodes.Insert(targetNode.Index + 1, tnNew);
                    targetNode.Expand();

                    // lvItem.Remove();
                    _model.Nodes[targetNode.Index].Nodes.Add(new Node(trackName));
                    lvItem.Font = new Font(lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Regular);
                    lvItem.ForeColor = Color.LightGray;
                }
            }


            tvMatchFiles.EndUpdate();
        }




        private void PopulateTreeView()
        {
            _model = new TreeModel();
            tvMatchFiles.Model = _model;
            
            //tvDirectoriesAdv.AllNodes.Clear();
            //TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"C:\dmb\dmb2021-10-09.ck61.naiant.flac16");
            if (info.Exists)
            {
                //Node rootNode = AddRoot(info.Name);
                //rootNode = new TreeNode(info.Name);
                //rootNode.Tag = info;
                
                foreach (KeyValuePair<string, FlacFileInfo> entry in frmMain.originalMetadata)
                {
                    Node rootNode = AddRoot(entry.Key, entry.Value);
                    if (false) { }
                }
            }
            if (false) { }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, Node nodeToAddTo)
        {
            Node aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new Node(subDir.Name);
                aNode.Tag = subDir;
                //aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private Node AddRoot(string text, FlacFileInfo flacFileInfo)
        {
            SongNode node = new SongNode();
            node.Text = text;
            node.Image = frmMain.imgListFileIcons.Images["folder"];
            node.Artist = flacFileInfo.Metadata.Artist;
            node.Title = flacFileInfo.Metadata.Title;
            node.Tracknumber = flacFileInfo.Metadata.Tracknumber;
            _model.Nodes.Add(node);
            return node;
        }



        private Node AddChild(Node parent, string text)
        {
            Node node = new Node(text);
            parent.Nodes.Add(node);
            return node;
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
        
        public class SongNode : Node
        {
            public string Artist { get; set; }
            public string Title { get; set; }
            public string Tracknumber { get; set; }
        }
        

        #endregion

    }
}
