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

namespace TagBot.App
{
    public partial class frmMultipleShowsFound : Form
    {
        public frmMain frmMain;
        public List<ShowSearchResponseContract> showList;

        public frmMultipleShowsFound()
        {
            InitializeComponent();
        }

        private void frmMultipleShowsFound_Load(object sender, EventArgs e)
        {
            lvShows.MultiSelect = false;
            lvShows.Items.Clear();
            foreach (ShowSearchResponseContract show in showList)
            {
                var item = new ListViewItem(new[] { show.Date, show.Artist, show.Venue + ", " + show.City + ", " + show.State });

                item.Text = show.Date;

                lvShows.Items.Add(item);
            }
            lvShows.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            lvShows.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUseSelectedShow_Click(object sender, EventArgs e)
        {
            if (lvShows.SelectedItems.Count == 0) {
                MessageBox.Show("Please select a show", "Select a show");
                return;
            }
            frmMain.showData = showList[lvShows.SelectedItems[0].Index];
            this.Close();
        }

        private void frmMultipleShowsFound_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lvShows.SelectedItems.Count > 0)
            {
                frmMain.showData = showList[lvShows.SelectedItems[0].Index];
            }
            else
            {
                frmMain.showData = showList.FirstOrDefault();
            }
        }

        private void lvShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theTracks = string.Empty;
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                foreach (var song in showList[(sender as ListView).SelectedItems[0].Index].Setlist)
                {
                    string temp = song.TrackNumber + " - " + song.TrackName + Environment.NewLine;
                    theTracks += temp;
                }

                rtbTracks.Text = theTracks;
            }
        }
    }
}
