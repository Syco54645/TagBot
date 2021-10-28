using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tagbot.Service;
using Tagbot.Service.contracts;
using Tagbot.Service.models;
using TagBot.Service;
using TagBot.Service.contracts;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class frmMain : Form
    {
        private string currentPath;
        private ShowSearchResponseContract showData;
        private Dictionary<string, FlacFileInfo> originalMetadata;
        private Dictionary<string, FlacFileInfo> proposedMetadata;
        frmDebug frmDebug = new frmDebug();

        public frmMain()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            PopulateTreeView();
            this.tvDirectories.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.tvDirectories_NodeMouseClick);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //txtDate.Text = "dmb2009-09-19";
        }

        private void btnGetShowData_Click(object sender, EventArgs e)
        {
            getShowData();
        }

        private void getShowData()
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = AppDomain.CurrentDomain.BaseDirectory + "../../../";
            string showDataJson = sqlite.getShow(txtDate.Text);

            showData = Utility.DeserializeObject<ShowSearchResponseContract>(showDataJson);
            frmDebug.ShowData = showDataJson;
        }

        #region File List
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
            lvAudioFiles.SelectedIndices.Clear();
            lvAudioFiles.Items.Clear();
            lvTextFiles.Items.Clear();
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

            /*foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, "folder");
                
                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Directory"), 
                    new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
                };
                item.SubItems.AddRange(subItems);
                lvAudioFiles.Items.Add(item);
            }*/
            List<string> files = new List<string>();
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                if (Utility.isSupportedAudio(file.Extension))
                {
                    files.Add(file.Name);
                }
            }
            createContentionVariables(files);

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                string extension = file.Extension;
                if (Utility.isSupportedAudio(extension))
                {
                    item = new ListViewItem(file.Name, Utility.getIconType(extension));
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, proposedMetadata[file.Name].Metadata.Tracknumber),
                        new ListViewItem.ListViewSubItem(item, proposedMetadata[file.Name].Metadata.Title),
                        new ListViewItem.ListViewSubItem(item, proposedMetadata[file.Name].Metadata.Artist),
                        new ListViewItem.ListViewSubItem(item, proposedMetadata[file.Name].Metadata.Album),
                    };

                    item.SubItems.AddRange(subItems);
                    lvAudioFiles.Items.Add(item);
                }
                else if (Utility.isInfoFile(extension))
                {
                    item = new ListViewItem(file.Name, Utility.getIconType(extension));

                    lvTextFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                    lvTextFiles.Items.Add(item);
                }
            }

            lvAudioFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void createContentionVariables(List<string> files)
        {
            originalMetadata = new Dictionary<string, FlacFileInfo>();
            proposedMetadata = new Dictionary<string, FlacFileInfo>();

            foreach (string filename in files)
            {
                FlacFileInfo flacInfo = Flac.getFlacFileInfo(this.currentPath + "\\" + filename);
                originalMetadata.Add(filename, flacInfo);
                proposedMetadata.Add(filename, flacInfo);
            }
            frmDebug.originalMetadata = Utility.SerializeObject(originalMetadata, true);
            frmDebug.proposedMetadata = Utility.SerializeObject(proposedMetadata, true);
        }

        private void lvAudioFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFiles = lvAudioFiles.SelectedItems;
            if (selectedFiles.Count > 0)
            {
                string fileName = selectedFiles[0].Text;

                FlacFileInfo flacInfo = originalMetadata[fileName];
                //FlacFileInfo flacInfo = Flac.getFlacFileInfo(this.currentPath + "\\" + fileName);
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
                txtMetadataTrackNumber.Text = flacInfo.Metadata.Tracknumber;
            }
            else
            {
                lblEncoder.Text = "";
                lblBitrate.Text = "";
                lblSampleRate.Text = "";
                lblChannels.Text = "";
                lblSize.Text = "";
                lblDuration.Text = "";
                txtMetadataTitle.Text = "";
                txtMetadataArtist.Text = "";
                txtMetadataAlbum.Text = "";
                txtMetadataDate.Text = "";
                txtMetadataTitle.Text = "";
                txtMetadataTrackNumber.Text = "";
            }
        }
        #endregion

        private void btnAutomate_Click_Original(object sender, EventArgs e)
        {
            getShowData();
            pbTagProgress.Value = 0;
            List<Track> tracks = showData.Setlist;
            var files = lvAudioFiles.Items;
            List<string> audioFiles = new List<string>();
            foreach (ListViewItem f in files)
            {
                string fileName = f.Text;
                string ext = fileName.Substring(Math.Max(0, fileName.Length - 5));
                if (ext == ".flac")
                {
                    audioFiles.Add(fileName);
                }
            }

            if (tracks.Count == audioFiles.Count)
            {
                // we can do this automatically more than likely
                for (int i = 0; i < audioFiles.Count; i++)
                {
                    string fileName = audioFiles[i];
                    string path = this.currentPath + "\\" + fileName;
                    Metadata metadata = new Metadata
                    {
                        Title = tracks[i].TrackName,
                        Tracknumber = Convert.ToString(tracks[i].TrackNumber),
                        Album = showData.Date + " " + showData.Venue + ", " + showData.City + ", " + showData.State
                    };
                    Flac.writeFlacTags(path, metadata);
                    int incrementAmount = 100 / audioFiles.Count;
                    pbTagProgress.Increment(incrementAmount * (i));
                }
                MessageBox.Show("Tagging Complete");
            }
            else
            {
                // scary needs to match stuff here
            }
            /*foreach (Track t in tracks)
            {

            }*/
            
        }

        
        private List<string> _getAudioFilesInCurrentDirector(ListView.ListViewItemCollection files)
        {
            List<string> audioFiles = new List<string>();
            foreach (ListViewItem f in files)
            {
                string fileName = f.Text;
                string ext = fileName.Substring(Math.Max(0, fileName.Length - 5));
                if (Utility.isSupportedAudio(ext))
                {
                    audioFiles.Add(fileName);
                }
            }

            return audioFiles;
        }
        private void btnAutomate_Click(object sender, EventArgs e)
        {
            getShowData();
            pbTagProgress.Value = 0;
            lvAudioFiles.SelectedIndices.Clear();
            List<Track> tracks = showData.Setlist;
            List<string> audioFiles = _getAudioFilesInCurrentDirector(lvAudioFiles.Items);

            if (tracks.Count == audioFiles.Count)
            {
                // we can do this automatically more than likely
                for (int i = 0; i < audioFiles.Count; i++)
                {
                    string filename = audioFiles[i];
                    Metadata metadata = new Metadata
                    {
                        Title = tracks[i].TrackName,
                        Tracknumber = Convert.ToString(tracks[i].TrackNumber),
                        Album = showData.Date + " " + showData.Venue + ", " + showData.City + ", " + showData.State
                    };
                    proposedMetadata[filename].Metadata = metadata;
                    
                    int incrementAmount = 100 / audioFiles.Count;
                    pbTagProgress.Increment(incrementAmount * (i));
                }
                MessageBox.Show("Please verify and save your files.", "Tagging Complete");
            }
            else
            {
                // scary needs to match stuff here
            }
        }

        private void lvTextFiles_DoubleClick(object sender, EventArgs e)
        {
            var selectedFiles = lvTextFiles.SelectedItems;
            string fileName = selectedFiles[0].Text;
            frmText frmText = new frmText(this.currentPath + "\\" + fileName);
            frmText.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDebug.IsDisposed == true)
            {
                frmDebug = new frmDebug();
            }
            frmDebug.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made with love for the DMB community by Syco54645");
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            var files = lvAudioFiles.SelectedItems;
            int incrementAmount = 100 / files.Count;
            pbTagProgress.Value = 0;

            List<string> audioFiles = new List<string>();
            for (int i = 0; i < files.Count; i++)
            {
                ListViewItem f = files[i];
                string filename = f.Text;
                string ext = filename.Substring(Math.Max(0, filename.Length - 5));
                if (ext == ".flac")
                {
                    audioFiles.Add(filename);

                    string path = this.currentPath + "\\" + filename;
                    Metadata metadata = proposedMetadata[filename].Metadata;
                    Flac.writeFlacTags(path, metadata);
                    pbTagProgress.Increment(incrementAmount * (i));
                }
            }
            MessageBox.Show("Flac tags saved.", "Saving Complete");
        }

        private void lvAudioFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                lvAudioFiles.MultiSelect = true;
                foreach (ListViewItem item in lvAudioFiles.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            frmMatch frmMatch = new frmMatch();
            frmMatch.workingFiles = _getAudioFilesInCurrentDirector(lvAudioFiles.Items);
            frmMatch.showData = showData;
            frmMatch.Show();
        }
    }
}
