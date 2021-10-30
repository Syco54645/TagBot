using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tagbot.Service.contracts;
using Tagbot.Service.models;

namespace TagBot.App.usercontrols
{
    public partial class ucManualMatch : UserControl
    {
        public List<string> workingFiles = new List<string>();
        public frmMain frmMain;

        public ucManualMatch()
        {
            InitializeComponent();
        }

        private void manualMatch_Load(object sender, EventArgs e)
        {
            initControl();
        }

        public void initControl()
        {
            lblOriginalArtist.Text = "";
            lblOriginalAlbum.Text = "";
            lblOriginalTitle.Text = "";
            lblOriginalNumber.Text = "";
            lblOriginalDate.Text = "";
            lvMatchTags.Clear();
            tvMatchFiles.Nodes.Clear();

            this.Dock = DockStyle.Fill;
            this.AutoSize = true;

            tvMatchFiles.AllowDrop = true;

            // populate tvMatchFiles with the files
            TreeNode node;
            foreach (string file in workingFiles)
            {
                // root node to tvMatchFiles
                node = tvMatchFiles.Nodes.Add(file);
            }
            tvMatchFiles.ExpandAll();

            // populate lvMatchTags with the tags
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvMatchTags.Columns.Add(header);
            lvMatchTags.View = View.Details;

            if (frmMain.showData != null)
            {
                foreach (Track track in frmMain.showData.Setlist)
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
            lvMatchTags.HeaderStyle = ColumnHeaderStyle.None;

            pnlTextFiles.Controls.Add(frmMain.ucTextFiles);
        }

        private void lvMatchTags_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(lvMatchTags.SelectedItems, DragDropEffects.Move);
        }

        private void tvMatchFiles_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void tvMatchFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void tvMatchFiles_DragOver(object sender, DragEventArgs e)
        {
            // get coordinates of the drop item
            Point targetPoint = tvMatchFiles.PointToClient(new Point(e.X, e.Y));

            // select node
            tvMatchFiles.SelectedNode = tvMatchFiles.GetNodeAt(targetPoint);
        }

        private void tvMatchFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
            {
                moveLvMatchTags(sender, e);
            }
            else
            {
                moveTvMatchFilesNodes(sender, e);
            }
        }

        private void moveLvMatchTags(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            Point targetPoint = tvMatchFiles.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = tvMatchFiles.GetNodeAt(targetPoint);
            TreeNode tnNew;

            while (targetNode.Level > 0)
            {
                targetNode = targetNode.Parent;
            }

            ListView.SelectedListViewItemCollection lstViewColl = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection));
            foreach (ListViewItem lvItem in lstViewColl)
            {
                string trackName = lvItem.Text;
                Track track = (Track)lvItem.Tag;
                tnNew = new TreeNode(lvItem.Text);
                tnNew.Tag = track;

                targetNode.Nodes.Insert(targetNode.Index + 1, tnNew);
                targetNode.Expand();

                // lvItem.Remove();
                lvItem.Font = new Font(lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Regular);
                lvItem.ForeColor = Color.LightGray;
            }
        }

        private void moveTvMatchFilesNodes(object sender, DragEventArgs e)
        {
            // get the location of the drop
            Point targetPoint = tvMatchFiles.PointToClient(new Point(e.X, e.Y));

            // get the node that was dragged
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // get the target node
            TreeNode targetNode = tvMatchFiles.GetNodeAt(targetPoint);
            TreeNode siblingNode = null;
            if (targetNode.Level > 0)
            {
                siblingNode = targetNode;
            }
            else
            {
                siblingNode = targetNode;
            }

            // we only want to be able to add to the parent
            while (targetNode.Level > 0)
            {
                targetNode = targetNode.Parent;
            }

            if (!draggedNode.Equals(targetNode))
            {
                TreeNodeCollection targetNodeList;

                if (draggedNode.Level != 0)
                {
                    targetNodeList = targetNode.Nodes;
                }
                else
                {
                    targetNodeList = tvMatchFiles.Nodes;
                }

                // remove node from current location
                // add to node at the target
                draggedNode.Remove();
                if (siblingNode != null)
                {
                    targetNodeList.Insert(siblingNode.Index + 1, draggedNode);
                }
                else
                {
                    targetNodeList.Add(draggedNode);
                }

                if (draggedNode.Level != 0)
                {
                    // expand only if we didnt drag a main level node  
                    targetNode.Expand();
                }
            }
        }

        private void tvMatchFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode clickedNode = e.Node;

            if (clickedNode.Level != 0)
            {
                return;
            }

            //MessageBox.Show(clickedNode.Text);
            var oTrackInfo = frmMain.originalMetadata[clickedNode.Text];
            lblOriginalArtist.Text = oTrackInfo.Metadata.Artist;
            lblOriginalAlbum.Text = oTrackInfo.Metadata.Album;
            lblOriginalTitle.Text = oTrackInfo.Metadata.Title;
            lblOriginalNumber.Text = oTrackInfo.Metadata.Tracknumber;
            lblOriginalDate.Text = oTrackInfo.Metadata.Date;
            //lblOriginalComment.Text = oTrackInfo.Metadata.Comment;

            frmMain.loadFlacTagsInEditor(frmMain.proposedMetadata[clickedNode.Text]);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            frmMain.fileMode();
        }
    }
}
