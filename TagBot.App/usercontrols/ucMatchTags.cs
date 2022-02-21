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
using TagBot.App.models;
using TagBot.App.Properties;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class ucMatchTags : UserControl
    {
        public frmMain frmMain;
        public ucMatchTags()
        {
            InitializeComponent();
        }

        private void ucMatchTags_Load(object sender, EventArgs e)
        {
            /*Sqlite sqlite = new Sqlite();
            sqlite.databasePath = Settings.Default.databaseLocation;
            string showDataJson = sqlite.getShow("2021-09-03");

            ShowSearchResponseContract showData = Utility.DeserializeObject<ShowSearchResponseContract>(showDataJson);
            populateMatchTags(showData);*/
            lvMatchTags.ItemDrag += lvMatchTags_ItemDrag;

            lvMatchTags.View = View.Details;
            lvMatchTags.HeaderStyle = ColumnHeaderStyle.None;
            lvMatchTags.FullRowSelect = true;
            lvMatchTags.Columns.Add("", -2);
            this.Dock = DockStyle.Fill;
            btnRapid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRapid.Image = ilButton.Images["DownArrow"];
            btnRapid.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
        }



        private void lvMatchTags_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(lvMatchTags.SelectedItems, DragDropEffects.Move);
        }

        public void populateMatchTags(ShowSearchResponseContract showData)
        {
            lvMatchTags.Items.Clear();
            if (showData != null)
            {
                foreach (Track track in showData.Setlist)
                {
                    string formattedName = frmMain.formatter.formatString(track, Service.FormatterType.Track);
                    formattedName = string.Format("{0} - {1}", track.TrackNumber, formattedName);
                    ListViewItem tempLVI = new ListViewItem(formattedName);
                    tempLVI.Tag = track;
                    tempLVI.Font = new Font(lvMatchTags.Font, FontStyle.Bold);
                    lvMatchTags.Items.Add(tempLVI);
                }
            }
            lvMatchTags.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMatchTags.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvMatchTags.Columns[0].Width = lvMatchTags.Width - 4 - SystemInformation.VerticalScrollBarWidth;
            tslTagCount.Text = "Tags: " + lvMatchTags.Items.Count.ToString();
        }

        private void btnMatchDone_Click(object sender, EventArgs e)
        {
            frmMain.fileMode();
            cancelRapid();
        }

        private void automate()
        {

            //lvAudioFiles.SelectedIndices.Clear();
            List<Track> tracks = frmMain.showData.Setlist;

            if (tracks.Count == frmMain.tvMatchFilesModel.Nodes.Count)
            {
                // we can do this automatically more than likely
                int i = 0;
                foreach (SongNode file in frmMain.tvMatchFilesModel.Nodes)
                {
                    string filename = file.Filename;
                    string title = tracks[i].TrackName;

                    frmMain.proposedMetadata[filename].Metadata.Title = title;
                    file.Nodes.Add(new Node(title));

                    frmMain.ucMatchFiles.expandMyMind();
                    lvMatchTags.Items[i].Font = new Font(lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Regular);
                    lvMatchTags.Items[i].ForeColor = Color.LightGray;
                    i++;
                }
                SongNode selectedTvMatchFilesNode = frmMain.ucMatchFiles.currentSelectNoded();
                if (selectedTvMatchFilesNode != null)
                {
                    frmMain.loadTagsInEditor(frmMain.proposedMetadata[selectedTvMatchFilesNode.Filename]);
                }
            }
            else
            {
                // scary needs to match stuff here
            }
        }

        public void enableAutomateButton()
        {
            splitMenuStrip.Items["basicToolStripMenuItem"].Enabled = frmMain.showData.Setlist.Count == frmMain.tvMatchFilesModel.Nodes.Count;
        }

        private void btnRapid_Click(object sender, EventArgs e)
        {
            var clickPos = btnRapid.PointToClient(new System.Drawing.Point(MousePosition.X, MousePosition.Y));

            // If click image show the menu
            /*Console.WriteLine("where the image is " + (btnRapid.Width - imageList1.Images["DownArrow"].Width).ToString());
            Console.WriteLine("where we clicked " + clickPos.X.ToString());*/
            
            if (frmMain.rapid.Doing == true)
            {
                cancelRapid();
            }
            else
            {
                if (clickPos.X >= (btnRapid.Width - ilButton.Images["DownArrow"].Width - 5))
                {
                    //MessageBox.Show(clickPos.X.ToString());
                    ShowMenuUnderControl();
                }
                else
                {
                    rapid();
                }
            }
            
        }

        public void ShowMenuUnderControl()
        {
            splitMenuStrip.Show(this, new Point(btnRapid.Location.X, btnRapid.Location.Y + btnRapid.Height), ToolStripDropDownDirection.BelowRight);   
        }

        private void rapid()
        {
            reset();
            frmMain.rapid.Doing = true;
            frmMain.rapid.Location = -1;
            btnRapid.Text = "Cancel";
            btnReset.Enabled = false;
            btnMatchDone.Enabled = false;
            //lvMatchTags.Enabled = false;
            cycleRapid();
        }

        private void cancelRapid()
        {
            CompleteRapid();
            reset();
        }

        private void CompleteRapid()
        {
            frmMain.rapid.Doing = false;
            frmMain.rapid.Location = -1;
            btnRapid.Text = "Automate";
            btnReset.Enabled = true;
            btnMatchDone.Enabled = true;
            lvMatchTags.Items[lvMatchTags.Items.Count - 1].Font = new Font(lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Regular);
            lvMatchTags.Items[lvMatchTags.Items.Count - 1].ForeColor = Color.LightGray;
        }

        public void cycleRapid()
        {
            if (frmMain.rapid.Location < (lvMatchTags.Items.Count - 1))
            {
                if (frmMain.rapid.Location >= 0)
                {
                    lvMatchTags.Items[frmMain.rapid.Location].Font = new Font(lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Regular);
                    lvMatchTags.Items[frmMain.rapid.Location].ForeColor = Color.LightGray;
                }
                frmMain.rapid.Location++;
                lvMatchTags.Items[frmMain.rapid.Location].ForeColor = Color.Red;
            }
            else
            {
                CompleteRapid();
            }
        }

        private void rapidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapid();
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            automate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void resetLvMatchTags()
        {
            foreach (ListViewItem item in lvMatchTags.Items)
            {
                item.Font = new Font(lvMatchTags.Items[0].SubItems[0].Font, FontStyle.Bold);
                item.ForeColor = Color.Black;
            }
        }

        public void reset()
        {
            resetLvMatchTags();
            frmMain.resetContentionVariables();
            frmMain.ucMatchFiles.populateTvMatchFiles();
        }
    }
}
