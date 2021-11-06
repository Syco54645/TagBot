using Aga.Controls.Tree;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tagbot.Service;
using Tagbot.Service.contracts;
using Tagbot.Service.models;
using TagBot.App.Properties;
using TagBot.App.usercontrols;
using TagBot.Log;
using TagBot.Service;
using TagBot.Service.contracts;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class frmMain : Form
    {
        public string currentPath = "";
        public ShowSearchResponseContract showData;
        public Dictionary<string, FlacFileInfo> originalMetadata;
        public Dictionary<string, FlacFileInfo> proposedMetadata;
        public DatabaseMeta databaseMeta;
        public TreeModel tvMatchFilesModel;

        private Logger _log = new Logger(100u);
        private List<Color> _randomColors = new List<Color> { Color.Red, Color.SkyBlue, Color.Green };
        private Random _r = new Random((int)DateTime.Now.Ticks);


        public ucTextFiles ucTextFiles = new ucTextFiles();
        frmDebug frmDebug = new frmDebug();
        ucManualMatch ucManualMatch = new ucManualMatch();
        public ucMatchFiles ucTvMatchFiles = new ucMatchFiles();
        public ucLvMatchTags ucLvMatchTags = new ucLvMatchTags();
        frmDbInfo frmDbInfo = new frmDbInfo();

        public frmMain()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ucManualMatch.frmMain = this;
            ucLvMatchTags.frmMain = this;
            pnlTagView.Controls.Add(ucLvMatchTags);

            ucTvMatchFiles.frmMain = this;
            pnlTvMatchFiles.Controls.Add(ucTvMatchFiles);

            ucTextFiles.Dock = DockStyle.Fill;
            scFlacText.Panel2.Controls.Add(ucTextFiles);
            ucTextFiles.frmMain = this;
            tsbSelectDirectory.Image = imgListFileIcons.Images["folder"];
            tsbSave.Image = imgListFileIcons.Images["save"];

            if (!string.IsNullOrEmpty(Settings.Default.startingDirectory))
            {
                UpdateCurrentPath(Settings.Default.startingDirectory);
                PopulateTreeView();
            }
            if (!string.IsNullOrEmpty(Settings.Default.databaseLocation))
            {
                getDatabaseMeta();
            }
            this.tvDirectories.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.tvDirectories_NodeMouseClick);

            tsDirectoryBrowser_Resize(this, e);
            if (databaseMeta == null)
            {
                btnDbInfo.Enabled = false;
            }
            tvDirectories.ExpandAll();
        }

        private void btnGetShowData_Click(object sender, EventArgs e)
        {
            getShowData();
        }

        private void getShowData()
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = Settings.Default.databaseLocation;
            string showDataJson = sqlite.getShow(txtDate.Text);

            showData = Utility.DeserializeObject<ShowSearchResponseContract>(showDataJson);
            frmDebug.ShowData = showDataJson;
            ucManualMatch.populateMatchTags(showData);
        }

        #region File List
        // tree view sample lifted from https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/creating-an-explorer-style-interface-with-the-listview-and-treeview?view=netframeworkdesktop-4.8
        private void PopulateTreeView()
        {
            tvDirectories.Nodes.Clear();
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(Settings.Default.startingDirectory);
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
            DirectoryInfo tag = (DirectoryInfo)node.Tag;
            UpdateCurrentPath(tag.FullName);
        }

        private void UpdateCurrentPath(string path)
        {
            this.currentPath = path;
            tstbLocation.Text = this.currentPath;
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
            ucTextFiles.clearListView();
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
                }
                else if (Utility.isInfoFile(extension))
                {
                    item = new ListViewItem(file.Name, Utility.getIconType(extension));

                    ucTextFiles.addItem(item);
                }
            }

            ucTvMatchFiles.PopulateTvMatchFiles();
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

        public void loadFlacTagsInEditor(FlacFileInfo flacInfo)
        {
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
            txtMetadataTrackNumber.Text = flacInfo.Metadata.Tracknumber;
        }

        private void lvAudioFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFiles = new List<string>(); // todo fix this
            if (selectedFiles.Count > 0)
            {
                //string fileName = selectedFiles[0].Text;

                //FlacFileInfo flacInfo = originalMetadata[fileName];
                //loadFlacTagsInEditor(flacInfo);
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
                txtMetadataTrackNumber.Text = "";
            }
        }
        #endregion

        private void btnAutomate_Click_Original(object sender, EventArgs e)
        {
            getShowData();
            pbTagProgress.Value = 0;
            List<Track> tracks = showData.Setlist;
            var files = new List<ListViewItem>(); // lvAudioFiles.Items; // todo fix this
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
        private void btnAutomate_Click(object sender, EventArgs e) // todo fix
        {
            /*getShowData();
            pbTagProgress.Value = 0;
            //lvAudioFiles.SelectedIndices.Clear();
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
            }*/
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

        private void tsbSave_Click(object sender, EventArgs e) // todo fix
        {
            /*var files = lvAudioFiles.SelectedItems;
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
            MessageBox.Show("Flac tags saved.", "Saving Complete");*/
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            /*frmMatch frmMatch = new frmMatch();
            frmMatch.workingFiles = _getAudioFilesInCurrentDirector(lvAudioFiles.Items);
            frmMatch.showData = showData;
            frmMatch.Show();*/

            /*ucManualMatch.workingFiles = _getAudioFilesInCurrentDirector(lvAudioFiles.Items);
            ucManualMatch.initControl();*/

            matchMode();
            _log.AddToLog("Some event to log.", _randomColors[_r.Next(3)]);
            srtfLog.Rtf = _log.GetLogAsRichText(true);
            srtfLog.ScrollToBottom();
        }

        public void fileMode()
        {
            pnlFileView.Visible = true;
            pnlTagView.Visible = false;
            scFlacText.Panel2.Controls.Add(ucTextFiles);
        }

        public void matchMode()
        {
            pnlFileView.Visible = false;
            pnlTagView.Visible = true;
        }

        private void tsbSelectDirectory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Properties.Settings.Default.startingDirectory = dialog.FileName;
                Properties.Settings.Default.Save();
                PopulateTreeView();
                UpdateCurrentPath(dialog.FileName);
            }
        }

        private void btnLoadDatabase_Click(object sender, EventArgs e)
        {
            // C:\Users\Frank\source\repos\TagBot\database.db
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Database File";
            dialog.Filter = "sqlite files|*.db";
            string initialDirectory = string.IsNullOrEmpty(Settings.Default.databaseLocation) ? AppDomain.CurrentDomain.BaseDirectory : Settings.Default.databaseLocation;
            dialog.InitialDirectory = initialDirectory;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.databaseLocation = dialog.FileName;
                Settings.Default.Save();
                getDatabaseMeta();
            }
        }

        private void getDatabaseMeta()
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = Settings.Default.databaseLocation;
            databaseMeta = Utility.DeserializeObject<DatabaseMeta>(sqlite.getDatabaseMeta());
            txtLoadedDatabase.Text = Settings.Default.databaseLocation;
            btnDbInfo.Enabled = true;
        }

        private void tsDirectoryBrowser_Resize(object sender, EventArgs e)
        {
            tstbLocation.Width = tsDirectoryBrowser.Width - (tsbSelectDirectory.Width + 50);
        }

        private void btnDbInfo_Click(object sender, EventArgs e)
        {
            if (frmDbInfo.IsDisposed)
            {
                frmDbInfo = new frmDbInfo();
            }
            frmDbInfo.displayDbMeta(databaseMeta);
            frmDbInfo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


































    }
}
