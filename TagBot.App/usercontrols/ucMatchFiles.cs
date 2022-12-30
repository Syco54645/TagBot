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
using TagBot.App.models;
using TagBot.App.Properties;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class ucMatchFiles : UserControl
    {
        public frmMain frmMain;
        //private TreeModel tvMatchFilesModel;
        public ucMatchFiles()
        {
            InitializeComponent();
        }

        private void ucMatchFiles_Load(object sender, EventArgs e)
        {
            if (frmMain.originalMetadata != null && frmMain.originalMetadata.Count > 0)
            {
                tvMatchFiles.BeginUpdate();
                populateTvMatchFiles();
                tvMatchFiles.EndUpdate();
            }

            // setup handlers for drag drop
            tvMatchFiles.DragDrop += tvDirectoriesAdv_DragDrop;
            tvMatchFiles.DragOver += tvDirectoriesAdv_DragOver;
            tvMatchFiles.ItemDrag += tvDirectoriesAdv_ItemDrag;
            tvMatchFiles.NodeMouseDoubleClick += tvDirectoriesAdv_NodeMouseDoubleClick;
            tvMatchFiles.NodeMouseClick += tvDirectoriesAdv_NodeMouseClick;
            tvMatchFiles.KeyUp += tvMatchFiles_KeyUp;
            tvMatchFiles.AllowDrop = true;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// The Purpose of this function is to get the clicked node and load the tags in to the editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvDirectoriesAdv_NodeMouseClick(object sender, TreeNodeAdvMouseEventArgs e)
        {
            frmMain.enablePlayerControls();
            SongNode node = (SongNode)frmMain.tvMatchFilesModel.Nodes[e.Node.Index];
            frmMain.loadTagsInEditor(frmMain.proposedMetadata[node.Filename]);
        }

        public SongNode currentSelectNoded()
        {
            if (tvMatchFiles.CurrentNode != null)
            {
                return (SongNode)frmMain.tvMatchFilesModel.Nodes[tvMatchFiles.CurrentNode.Index];
            }
            return null;
        }

        public void clearSelectedNode()
        {
            frmMain.disablePlayerControls();
            tvMatchFiles.ClearSelection();
        }

        private void tvDirectoriesAdv_NodeMouseDoubleClick(object sender, TreeNodeAdvMouseEventArgs e)
        {
            if (frmMain.rapid.Doing)
            {
                tvMatchFiles.BeginUpdate();

                Point clickedPoint = new Point(e.X, e.Y);
                TreeNodeAdv targetNode = tvMatchFiles.GetNodeAt(clickedPoint);
                if (targetNode.Level > 1)
                {
                    return;
                }

                ListViewItem lvItem = frmMain.ucMatchTags.lvMatchTags.Items[frmMain.rapid.Location];
                Track track = (Track)lvItem.Tag;
                string trackName = frmMain.formatter.formatString(track, Service.FormatterType.Track);

                Node tempNode = new Node(trackName);
                tempNode.Tag = lvItem;
                frmMain.tvMatchFilesModel.Nodes[targetNode.Index].Nodes.Add(tempNode);

                frmMain.ucMatchTags.cycleRapid();
                frmMain.clearTagEditor(false);
                tvMatchFiles.EndUpdate();
                updateContention();
                
                // stop the double click from causing the node to expand/collapse
                targetNode.Collapsed += tvDirectoriesAdv_Expanding;
            }
            else
            {
                if (e.Control is NodeTextBox)
                {
                    //MessageBox.Show(e.Node.Tag.ToString());
                }
            }
            SongNode node = (SongNode)frmMain.tvMatchFilesModel.Nodes[e.Node.Index];
            frmMain.loadTagsInEditor(frmMain.proposedMetadata[node.Filename]);
        }

        private void tvDirectoriesAdv_Expanding(object sender, TreeViewAdvEventArgs e)
        {
            if (frmMain.rapid.Doing)
            {
                e.Node.IsExpanded = true;
            }
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
            if (e.Data.GetDataPresent(typeof(TreeNodeAdv[])) && tvMatchFiles.DropPosition.Node != null) // dragging within the Files
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
            else if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection))) // dropping a tag from the tags to the files
            {
                Point targetPoint = tvMatchFiles.PointToClient(new Point(e.X, e.Y));
                TreeNodeAdv targetNode = tvMatchFiles.GetNodeAt(targetPoint);
                if (targetNode == null) return;

                while (targetNode.Level > 1)
                {
                    targetNode = targetNode.Parent;
                }

                ListView.SelectedListViewItemCollection lstViewColl = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection));
                foreach (ListViewItem lvItem in lstViewColl)
                {
                    Track track = (Track)lvItem.Tag;
                    string trackName = frmMain.formatter.formatString(track, Service.FormatterType.Track);
                    
                    targetNode.Expand();

                    // lvItem.Remove();
                    Node tempNode = new Node(trackName);
                    tempNode.Tag = lvItem;
                    frmMain.tvMatchFilesModel.Nodes[targetNode.Index].Nodes.Add(tempNode);
                    lvItem.Font = new Font(frmMain.ucMatchTags.lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Regular);
                    lvItem.ForeColor = Color.LightGray;
                }
            }
            frmMain.clearTagEditor(false);
            tvMatchFiles.EndUpdate();
            updateContention();
        }

        public void expandMyMind()
        {
            tvMatchFiles.ExpandAll();
        }

        public void updateContention()
        {
            if (frmMain.tvMatchFilesModel != null)
            {
                foreach (SongNode node in frmMain.tvMatchFilesModel.Nodes)
                {
                    string combinedTitle = string.Join(" > ", node.Nodes.Select(x => x.Text).ToArray());
                    int trackNumber = node.Index + 1;
                    frmMain.proposedMetadata[node.Filename].Metadata.Title = string.IsNullOrEmpty(combinedTitle) ? frmMain.proposedMetadata[node.Filename].Metadata.Title : combinedTitle;
                    frmMain.proposedMetadata[node.Filename].Metadata.Tracknumber = trackNumber.ToString();
                }
            }
            else
            {
                MessageBox.Show("Contention generation error. Probably occured because no files were found in the working directory.");
            }
        }

        public void populateTvMatchFiles()
        {
            frmMain.tvMatchFilesModel = new TreeModel();
            tvMatchFiles.Model = frmMain.tvMatchFilesModel;
            
            foreach (KeyValuePair<string, AudioFileInfo> entry in frmMain.originalMetadata)
            {
                Node rootNode = addRoot(entry.Key, entry.Value);
            }
            resizeCols();
        }

        private void resizeCols()
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
                        }
                        newWidth += maxControlWidth;
                    }
                }
                col.Width = newWidth;
                newWidth = 0;
            }
        }


        private Node addRoot(string text, AudioFileInfo audioFileInfo)
        {
            SongNode node = new SongNode();
            node.Text = text;
            node.Filename = text;
            node.Image = frmMain.imgListFileIcons.Images["audio"];
            node.Artist = audioFileInfo.Metadata.Artist;
            node.Title = audioFileInfo.Metadata.Title;
            node.Tracknumber = audioFileInfo.Metadata.Tracknumber;
            node.Album = audioFileInfo.Metadata.Album;
            frmMain.tvMatchFilesModel.Nodes.Add(node);
            return node;
        }

        private void tvMatchFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (tvMatchFiles.SelectedNode.Level < 2)
                {
                    return;
                }

                string tagText = getTextFromTvMatchFilesNodeTag(tvMatchFiles.SelectedNode);
                int idx = frmMain.ucMatchTags.getLvMatchTagsItemIndexFromText(tagText);
                removeTagMatch(idx);
            }
        }

        public string getTextFromTvMatchFilesNodeTag(TreeNodeAdv selectedNode)
        {
            string tagText = ((ListViewItem)((Node)selectedNode.Tag).Tag).Text;
            return tagText;
        }

        public void removeTagMatch(int idx)
        {
            int parentIndex = tvMatchFiles.SelectedNode.Parent.Index;
            string filename = ((SongNode)((Node)tvMatchFiles.SelectedNode.Tag).Parent).Filename;
            frmMain.ucMatchTags.lvMatchTags.Items[idx].Font = new Font(frmMain.ucMatchTags.lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Bold);
            frmMain.ucMatchTags.lvMatchTags.Items[idx].ForeColor = Color.Black;
            frmMain.tvMatchFilesModel.Nodes[parentIndex].Nodes.RemoveAt(tvMatchFiles.SelectedNode.Index);

            if (frmMain.tvMatchFilesModel.Nodes[parentIndex].Nodes.Count > 0)
            {
                frmMain.proposedMetadata[filename].Metadata.Title = "";
                foreach (Node n in frmMain.tvMatchFilesModel.Nodes[parentIndex].Nodes)
                {
                    if (!String.IsNullOrEmpty(frmMain.proposedMetadata[filename].Metadata.Title)) {
                        frmMain.proposedMetadata[filename].Metadata.Title += " > ";
                    }
                    frmMain.proposedMetadata[filename].Metadata.Title += n.Text;
                }
            }
            else
            {
                // restore the metadata to what it once was
                frmMain.proposedMetadata[filename] = frmMain.originalMetadata[filename];
            }
        }
    }
}
