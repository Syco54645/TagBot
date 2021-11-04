using Aga.Controls.Tree;
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

            tvDirectoriesAdv.BeginUpdate();
            PopulateTreeView();
            tvDirectoriesAdv.EndUpdate();
        }







        private void PopulateTreeView()
        {
            _model = new TreeModel();
            tvDirectoriesAdv.Model = _model;
            
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



        private Node AddChild(Node parent)
        {
            Node node = new Node("Child Node " + parent.Nodes.Count.ToString());
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
