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
        }

        

        private void lvMatchTags_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(lvMatchTags.SelectedItems, DragDropEffects.Move);
        }

        


        #region forklift
        public void populateMatchTags(ShowSearchResponseContract showData)
        {
            lvMatchTags.Items.Clear();
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

        private void btnMatchDone_Click(object sender, EventArgs e)
        {
            frmMain.fileMode();
        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            string albumFormatter = string.IsNullOrEmpty(Settings.Default.albumFormatterString) ? "%d - %v - %c, %s" : Settings.Default.albumFormatterString;
            Service.Formatter formatter = new Service.Formatter(frmMain.showData, Settings.Default.customDateFormatter);
            string albumTitle = formatter.formatString(albumFormatter, Service.FormatterType.Album); // frmMain.showData.Date.Trim() + " - " + frmMain.showData.Venue.Trim() + frmMain.showData.City.Trim() + ", " + frmMain.showData.State.Trim();
            if (false) { }
        }
    }
}
