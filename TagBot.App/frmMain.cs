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
using TagBot.App.models;
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
        public Dictionary<string, AudioFileInfo> originalMetadata;
        public Dictionary<string, AudioFileInfo> proposedMetadata;
        public DatabaseMeta databaseMeta;
        public TreeModel tvMatchFilesModel;
        public Formatter formatter = new Formatter(!string.IsNullOrEmpty(Settings.Default.customDateFormatter) ? Settings.Default.customDateFormatter : Settings.Default.defaultCustomDateFormatter);
        public Rapid rapid = new Rapid();

        public Logger log = new Logger(100u);
        private List<Color> _randomColors = new List<Color> { Color.Red, Color.SkyBlue, Color.Green };
        private Random _r = new Random((int)DateTime.Now.Ticks);
        public ScrollingRichTextBox rtfLogger;

        public ucTextFiles ucTextFiles = new ucTextFiles();
        frmDebug frmDebug = new frmDebug();
        public ucMatchFiles ucMatchFiles = new ucMatchFiles();
        public ucMatchTags ucMatchTags = new ucMatchTags();
        frmDbInfo frmDbInfo = new frmDbInfo();
        frmPreferences frmPreferences = new frmPreferences();
        frmConfirmation frmConfirmation = new frmConfirmation();
        frmMultipleShowsFound frmMultipleShowsFound = new frmMultipleShowsFound();
        frmUpdate frmUpdate = new frmUpdate();
        frmAbout frmAbout = new frmAbout();

        public frmMain()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string getAssemblyVersion()
        {
            return frmAbout.AssemblyVersion;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setApplicationTitle();
            log.rtf = srtfLog;
            ucMatchTags.frmMain = this;
            pnlTagView.Controls.Add(ucMatchTags);

            ucMatchFiles.frmMain = this;
            pnlTvMatchFiles.Controls.Add(ucMatchFiles);

            ucTextFiles.Dock = DockStyle.Fill;
            scFlacText.Panel2.Controls.Add(ucTextFiles);
            ucTextFiles.frmMain = this;
            tsbSelectDirectory.Image = imgListFileIcons.Images["folder"];
            tsbSave.Image = imgListFileIcons.Images["save"];
            tsbRefresh.Image = imgListFileIcons.Images["refresh"];

            setupMetadataTextbox();

            _clearFileInfoLabels();
            fileMode();

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
            updateFormatterStrings();
        }

        private void _clearFileInfoLabels()
        {
            foreach (Control ctrl in grpFIleInfo.Controls)
            {
                if (ctrl is Label)
                {
                    if (ctrl.Tag != null && !string.IsNullOrEmpty(ctrl.Tag.ToString()) && ctrl.Tag.ToString() == "info")
                    {
                        ctrl.Text = string.Empty;
                    }
                }
            }
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
            List<ShowSearchResponseContract> temp = Utility.DeserializeObject<List<ShowSearchResponseContract>>(showDataJson); 
            if (temp.Count == 0)
            {
                MessageBox.Show("No show results found.", "No Data");
                fileMode();
                return;
            }
            if (temp.Count == 1)
            {
                showData = temp[0];
            }
            else
            {
                if (frmMultipleShowsFound.IsDisposed)
                {
                    frmMultipleShowsFound = new frmMultipleShowsFound();
                }
                frmMultipleShowsFound.frmMain = this;
                frmMultipleShowsFound.showList = temp;
                frmMultipleShowsFound.StartPosition = FormStartPosition.CenterParent;
                frmMultipleShowsFound.ShowDialog();
            }

            //showData = Utility.DeserializeObject<ShowSearchResponseContract>(showDataJson);
            ucMatchTags.populateMatchTags(showData);
            ucMatchTags.enableAutomateButton();
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
            tvDirectories.ExpandAll();
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

        List<string> getAudioFilesInDirectory(FileInfo[] files)
        {
            List<string> response = new List<string>();
            foreach (FileInfo file in files)
            {
                if (Utility.isSupportedAudio(file.Extension, Settings.Default.enableMp3))
                {
                    response.Add(file.Name);
                }
            }

            return response;
        }

        private void tvDirectories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string oldCurrentPath = currentPath;
            UpdateCurrentPath(e);
            string newCurrentPath = currentPath;

            if (oldCurrentPath != newCurrentPath)
            {
                clearTagEditor();
                TreeNode newSelected = e.Node;
                ucTextFiles.clearListView();
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;

                DateCheckResponseContract dateCheck = Utility.dateDir(nodeDirInfo.Name);
                if (dateCheck.IsDate == true)
                {
                    txtDate.Text = dateCheck.Date;
                }
                else
                {
                    txtDate.Text = string.Empty;
                }

                List<string> files = getAudioFilesInDirectory(nodeDirInfo.GetFiles());
                
                createContentionVariables(files);
                tslMatchFilesCount.Text = "Files: " + originalMetadata.Count.ToString();

                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    string extension = file.Extension;
                    if (extension == ".mp3" && !Settings.Default.enableMp3)
                    {
                        log.AddErrorToRtf("Mp3 file detected and Mp3 mode is not enabled. Please enable it in preferences.");
                    }
                    if (Utility.isSupportedAudio(extension, Settings.Default.enableMp3))
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

                ucMatchFiles.populateTvMatchFiles();
            }
        }

        public void resetContentionVariables()
        {
            // cheap way to do a deep clone
            proposedMetadata = Utility.DeserializeObject<Dictionary<string, AudioFileInfo>>(Utility.SerializeObject<Dictionary<string, AudioFileInfo>>(originalMetadata));
        }

        private void createContentionVariables(List<string> files)
        {
            originalMetadata = new Dictionary<string, AudioFileInfo>();
            proposedMetadata = new Dictionary<string, AudioFileInfo>();
            try
            {

                foreach (string filename in files)
                {
                    FileInfo fileInfo = new FileInfo(filename);
                    AudioFileInfo audioFileInfo = new AudioFileInfo();
                    if (fileInfo.Extension == ".flac")
                    {
                        audioFileInfo = Flac.getFileInfo(this.currentPath + "\\" + filename);
                    }
                    else
                    {
                        if (Settings.Default.enableMp3)
                        {
                            audioFileInfo = Mp3.getFileInfo(this.currentPath + "\\" + filename);
                        }
                        else
                        {
                            log.AddErrorToRtf("Mp3 file detected and Mp3 mode is not enabled. Please enable it in preferences.");
                        }
                    }
                    originalMetadata.Add(filename, audioFileInfo);
                }

                resetContentionVariables();
            }
            catch (Exception ex)
            {
                log.AddErrorToRtf(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        public void loadTagsInEditor(AudioFileInfo audioFileInfo)
        {
            lblCurrentFile.Text = audioFileInfo.Filename;
            lblEncoder.Text = audioFileInfo.Encoder;
            lblBitrate.Text = audioFileInfo.Bitrate;
            lblSampleRate.Text = audioFileInfo.SampleRate;
            lblChannels.Text = audioFileInfo.Channels;
            lblSize.Text = audioFileInfo.Size.ToString();
            lblDuration.Text = audioFileInfo.Duration.ToString();

            txtMetadataTitle.Text = audioFileInfo.Metadata.Title;
            txtMetadataArtist.Text = audioFileInfo.Metadata.Artist;
            txtMetadataAlbum.Text = audioFileInfo.Metadata.Album;
            txtMetadataDate.Text = audioFileInfo.Metadata.Date;
            txtMetadataTrackNumber.Text = audioFileInfo.Metadata.Tracknumber;
            txtMetadataComment.Text = audioFileInfo.Metadata.Comment;
        }

        public void clearTagEditor(bool clearOverall = true)
        {
            lblCurrentFile.Text = string.Empty;
            lblEncoder.Text = string.Empty;
            lblBitrate.Text = string.Empty;
            lblSampleRate.Text = string.Empty;
            lblChannels.Text = string.Empty;
            lblSize.Text = string.Empty;
            lblDuration.Text = string.Empty;

            txtMetadataTitle.Text = string.Empty;
            txtMetadataArtist.Text = string.Empty;
            txtMetadataAlbum.Text = string.Empty;
            txtMetadataDate.Text = string.Empty;
            txtMetadataTrackNumber.Text = string.Empty;
            txtMetadataComment.Text = string.Empty;
            
            if (clearOverall)
            {
                txtOverallAlbum.Text = string.Empty;
                txtOverallArtist.Text = string.Empty;
                txtOverallComment.Text = string.Empty;
                txtOverallDate.Text = string.Empty;
            }
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
            frmDebug.frmMain = this;
            frmDebug.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Made with love for the DMB community by Syco54645");
            if (frmAbout.IsDisposed)
            {
                frmAbout = new frmAbout();
            }
            centerToMainForm(frmAbout);
            frmAbout.ShowDialog();
        }

        private void saveTags()
        {
            if (proposedMetadata != null)
            {
                if (frmConfirmation.IsDisposed == true)
                {
                    frmConfirmation = new frmConfirmation();
                }
                frmConfirmation.frmMain = this;
                frmConfirmation.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Tags Loaded.");
            }
        }

        private void tsbSave_Click(object sender, EventArgs e) // todo fix
        {
            saveTags();
            //DirectoryInfo nodeDirInfo = (DirectoryInfo)currentPath;
            DirectoryInfo nodeDirInfo = new DirectoryInfo(currentPath);

            List<string> files = getAudioFilesInDirectory(nodeDirInfo.GetFiles());

            createContentionVariables(files);
            ucMatchFiles.populateTvMatchFiles();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDate.Text))
            {
                getShowData();
                matchMode();
                //log.AddToLog("Some event to log.", _randomColors[_r.Next(3)]);
                log.AddNoticeToRtf("Searching " + txtDate.Text);
            }
            else
            {
                MessageBox.Show("You need to enter a value to search on.");
            }
        }

        public void fileMode()
        {
            pnlFileView.Visible = true;
            pnlTagView.Visible = false;
            toggleTagFields(false);
        }

        public void matchMode()
        {
            ucMatchFiles.updateContention();
            pnlFileView.Visible = false;
            pnlTagView.Visible = true;
            toggleTagFields(true);
        }

        /// <summary>
        /// The purpose of this function is to enable and disable fields based on the mode that
        /// The app is currently in. It is currently hard coded to iterate over the grpCommonTags controls
        /// </summary>
        /// <param name="enabled"></param>
        public void toggleTagFields(bool enabled)
        {
            foreach (Control ctrl in grpCommonTags.Controls)
            {
                if (ctrl is TextBox)
                {
                    /*(ctrl as TextBox).ReadOnly = enabled;
                    MetadataTextBox tag = (MetadataTextBox)ctrl.Tag;
                    if (!string.IsNullOrEmpty(tag.MutuallyExclusiveField))
                    {
                        (grpFileTags.Controls[tag.MutuallyExclusiveField] as TextBox).ReadOnly = !enabled;
                    }*/
                }
                else if (ctrl is Button)
                {
                    ctrl.Enabled = enabled;
                }
            }
            if (enabled)
            {
                txtMetadataTitle.ReadOnly = false;
                txtMetadataTrackNumber.ReadOnly = false;
            }
            else
            {
                txtMetadataTitle.ReadOnly = true;
                txtMetadataTrackNumber.ReadOnly = true;
            }
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
            loadDatabase();
        }

        private void loadDatabase()
        {
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

        /// <summary>
        /// The purpose of this function is to get the "metadata" from the database
        /// This includes things such as artists, song count, show count, schema version
        /// </summary>

        private void getDatabaseMeta()
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = Settings.Default.databaseLocation;
            string requiredDatabaseMeta = Settings.Default.requiredDatabaseMeta;
            databaseMeta = Utility.DeserializeObject<DatabaseMeta>(sqlite.getDatabaseMeta(requiredDatabaseMeta));
            txtLoadedDatabase.Text = Settings.Default.databaseLocation;
            btnDbInfo.Enabled = true;
            if (databaseMeta.Unload == true)
            {
                string errorMessage = "Selected Database is incorrect. Please Load a new one.";
                if (!string.IsNullOrEmpty(databaseMeta.Error))
                {
                    errorMessage += Environment.NewLine + databaseMeta.Error;
                }
                MessageBox.Show(errorMessage, "Database Error");
                loadDatabase();
            }
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
            frmDbInfo.frmMain = this;
            frmDbInfo.displayDbMeta(databaseMeta);
            frmDbInfo.StartPosition = FormStartPosition.CenterParent;
            frmDbInfo.ShowDialog();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (databaseMeta == null)
            {
                loadDatabase();
            }
            if (frmPreferences.IsDisposed)
            {
                frmPreferences = new frmPreferences();
            }
            frmPreferences.frmMain = this;
            frmPreferences.StartPosition = FormStartPosition.CenterParent;
            frmPreferences.ShowDialog();
        }

        private void btnAutoFillCommonTags_Click(object sender, EventArgs e)
        {
            _autoFillDate();
            _autoFillAlbum();
            _autoFillComment();
            _autoFillArtist();

            _autoFillPostHook();
        }

        private void _autoFillDate()
        {
            txtOverallDate.Text = formatter.formatDate(showData.Date);
            _autoFillPostHook();
        }

        private void _autoFillAlbum()
        {
            string albumTitle = formatter.formatString(showData, Service.FormatterType.Album);
            txtOverallAlbum.Text = albumTitle;
            _autoFillPostHook();
        }

        private void _autoFillComment()
        {
            txtOverallComment.Text = "Source: " + new DirectoryInfo(currentPath).Name;
            _autoFillPostHook();
        }

        private void _autoFillArtist()
        {
            var artistTransformationDict = formatter.artistTransformationDict;
            txtOverallArtist.Text = (artistTransformationDict.ContainsKey(showData.Artist) && !string.IsNullOrEmpty(artistTransformationDict[showData.Artist])) ? artistTransformationDict[showData.Artist] : showData.Artist;
            _autoFillPostHook();
        }

        private void _autoFillPostHook()
        {
            ucMatchFiles.clearSelectedNode();
            clearTagEditor(false);
            /*SongNode selectedTvMatchFilesNode = ucMatchFiles.currentSelectNoded();
            if (selectedTvMatchFilesNode != null)
            {
                loadTagsInEditor(proposedMetadata[selectedTvMatchFilesNode.Filename]);
            }*/
        }

        /// <summary>
        /// The purpose of this function is to set the persistent formatter's settings if they are changed via preferences.
        /// This function should be called at form load as well as when we save the settings in preferences
        /// </summary>
        public void updateFormatterStrings()
        {
            formatter.customDateFormatter = !string.IsNullOrEmpty(Settings.Default.customDateFormatter) ? Settings.Default.customDateFormatter : Settings.Default.defaultCustomDateFormatter;
            formatter.albumFormatterString = !string.IsNullOrEmpty(Settings.Default.albumFormatterString) ? Settings.Default.albumFormatterString : Settings.Default.defaultAlbumFormatterString;
            formatter.titleFormatterString = !string.IsNullOrEmpty(Settings.Default.titleFormatterString) ? Settings.Default.titleFormatterString : Settings.Default.defaultTitleFormatterString;
            formatter.artistTransformationDict = !string.IsNullOrEmpty(Settings.Default.artistTransformation) ? Utility.DeserializeObject<Dictionary<string, string>>(Settings.Default.artistTransformation) : Utility.DeserializeObject<Dictionary<string, string>>(Settings.Default.defaultArtistTransformation);
            setApplicationTitle();
        }

        /// <summary>
        /// The purpose of this function is to set up the metadata text box tags and event handlers
        /// </summary>
        public void setupMetadataTextbox()
        {
            txtOverallAlbum.Tag = new MetadataTextBox
            {
                MutuallyExclusiveField = "txtMetadataAlbum",
                MetadataTextboxType = MetadataTextboxType.Overall,
                FieldInMetadata = "Album"
            };

            txtOverallComment.Tag = new MetadataTextBox
            {
                MutuallyExclusiveField = "txtMetadataComment",
                MetadataTextboxType = MetadataTextboxType.Overall,
                FieldInMetadata = "Comment"
            };

            txtOverallDate.Tag = new MetadataTextBox
            {
                MutuallyExclusiveField = "txtMetadataDate",
                MetadataTextboxType = MetadataTextboxType.Overall,
                FieldInMetadata = "Date"
            };

            txtOverallArtist.Tag = new MetadataTextBox
            {
                MutuallyExclusiveField = "txtMetadataArtist",
                MetadataTextboxType = MetadataTextboxType.Overall,
                FieldInMetadata = "Artist"
            };

            txtMetadataTitle.Tag = new MetadataTextBox
            {
                MetadataTextboxType = MetadataTextboxType.Single,
                FieldInMetadata = "Title"
            };

            txtMetadataTrackNumber.Tag = new MetadataTextBox
            {
                MetadataTextboxType = MetadataTextboxType.Single,
                FieldInMetadata = "Tracknumber"
            };

            txtMetadataArtist.Tag = new MetadataTextBox
            {
                MetadataTextboxType = MetadataTextboxType.Single,
                FieldInMetadata = "Artist"
            };

            txtMetadataAlbum.Tag = new MetadataTextBox
            {
                MetadataTextboxType = MetadataTextboxType.Single,
                FieldInMetadata = "Album"
            };

            txtMetadataDate.Tag = new MetadataTextBox
            {
                MetadataTextboxType = MetadataTextboxType.Single,
                FieldInMetadata = "Date"
            };

            txtMetadataComment.Tag = new MetadataTextBox
            {
                MetadataTextboxType = MetadataTextboxType.Single,
                FieldInMetadata = "Comment"
            };

            txtOverallAlbum.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtOverallComment.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtOverallDate.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtOverallArtist.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtMetadataTitle.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtMetadataTrackNumber.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtMetadataArtist.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtMetadataAlbum.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtMetadataDate.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
            txtMetadataComment.TextChanged += new System.EventHandler(this.txtMetadataFieldEditor_TextChanged);
        }

        /// <summary>
        /// The purpose of this function is to propagate metadata changes from text boxes through to the proposedMetadata object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMetadataFieldEditor_TextChanged(object sender, EventArgs e)
        {
            TextBox ctrl = (sender as TextBox);
            MetadataTextBox tag = (MetadataTextBox)ctrl.Tag;

            if (tag.MetadataTextboxType == MetadataTextboxType.Overall)
            {
                foreach (KeyValuePair<string, AudioFileInfo> entry in proposedMetadata)
                {
                    entry.Value.Metadata[tag.FieldInMetadata] = ctrl.Text;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(lblCurrentFile.Text))
                {
                    proposedMetadata[lblCurrentFile.Text].Metadata[tag.FieldInMetadata] = ctrl.Text;
                }
            }
        }

        private void saveTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTags();
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUpdate.IsDisposed)
            {
                frmUpdate = new frmUpdate();
            }
            frmUpdate.frmMain = this;
            centerToMainForm(frmUpdate);
            frmUpdate.Show();
        }

        public void centerToMainForm(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X + (this.Width - form.Width) / 2, this.Location.Y + (this.Height - form.Height) / 2);
        }

        private void setApplicationTitle()
        {
            this.Text = "TagBot " + frmAbout.AssemblyVersion;
            if (Settings.Default.enableMp3)
            {
                this.Text += " - Mp3 Mode Enaged!!!";
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            PopulateTreeView();
        }

        private void btnAutofillDate_Click(object sender, EventArgs e)
        {
            _autoFillDate();
        }

        private void btnAutofillAlbum_Click(object sender, EventArgs e)
        {
            _autoFillAlbum();
        }

        private void btnAutofillArtist_Click(object sender, EventArgs e)
        {
            _autoFillArtist();
        }

        private void btnAutofillComment_Click(object sender, EventArgs e)
        {
            _autoFillComment();
        }
    }
}
