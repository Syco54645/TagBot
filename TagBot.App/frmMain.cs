using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tagbot.Service;
using TagBot.Service;
using TagBot.Service.contracts;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class frmMain : Form
    {
        private string currentPath;

        public frmMain()
        {
            InitializeComponent();

            PopulateTreeView();
            this.tvDirectories.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.tvDirectories_NodeMouseClick);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtDate.Text = "dmb2009-09-19";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = AppDomain.CurrentDomain.BaseDirectory + "../../../";
            rtfResult.Text = sqlite.getShow(txtDate.Text);
        }

        // tree view sample lifted from https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/creating-an-explorer-style-interface-with-the-listview-and-treeview?view=netframeworkdesktop-4.8
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"C:\dmb");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                tvDirectories.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void UpdateCurrentPath(System.Windows.Forms.MouseEventArgs e)
        {
            System.Drawing.Point point = new System.Drawing.Point(e.X, e.Y);

            TreeNode node = tvDirectories.GetNodeAt(point);
            var parentNodes = GetParentNodes(node);
            this.currentPath = "c:\\" + String.Join("\\", parentNodes.Select(x => x.Text));
        }

        private TreeNode[] GetParentNodes(TreeNode node_)
        {
            TreeNode[] nodes_ = new TreeNode[node_.Level + 1];
            nodes_[0] = node_;
            for (int i = 1; i < nodes_.Length; i++)
            {
                nodes_[i] = nodes_[i - 1].Parent;
            }
            Array.Reverse(nodes_);
            return nodes_;
        }

        private void tvDirectories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            lvFiles.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            UpdateCurrentPath(e);

            DateCheckResponseContract dateCheck = Utility.dateDir(nodeDirInfo.Name);
            if (dateCheck.IsDate == true)
            {
                txtDate.Text = dateCheck.Date;
            }
            else
            {
                txtDate.Text = string.Empty;
            }

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, "folder");
                
                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Directory"), 
                    new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
                };
                item.SubItems.AddRange(subItems);
                lvFiles.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                string extension = file.Extension;
                item = new ListViewItem(file.Name, Utility.getIconType(extension));
                subItems = new ListViewItem.ListViewSubItem[]
                { 
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                };

                item.SubItems.AddRange(subItems);
                lvFiles.Items.Add(item);
            }

            lvFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lvFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foo = lvFiles.SelectedItems;
            //foo[0].Name;
            if (foo.Count > 0)
            {
                string fileName = foo[0].Text;

                Flac flac = new Flac();
                FlacFileInfo flacInfo = flac.getFlacFileInfo(this.currentPath + "\\" + fileName);
                lblEncoder.Text = flacInfo.Encoder;
                lblBitrate.Text = flacInfo.Bitrate;
                lblSampleRate.Text = flacInfo.SampleRate;
                lblChannels.Text = flacInfo.Channels;
                lblSize.Text = flacInfo.Size.ToString();
                lblDuration.Text = flacInfo.Duration.ToString();

                txtMetadataTitle.Text = flacInfo.Metadata.Title;
                txtMetadataArtist.Text = flacInfo.Metadata.Artist;
                txtMetadataAlbum.Text = flacInfo.Metadata.Album;
                txtMetadataDate.Text = flacInfo.Metadata.Date;
                txtMetadataTitle.Text = flacInfo.Metadata.Title;
                txtMetadataTrackNumber.Text = flacInfo.Metadata.TrackNumber;
            }
            
        }
    }
}
