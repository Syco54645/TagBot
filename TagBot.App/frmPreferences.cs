using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tagbot.Service;
using Tagbot.Service.contracts;
using Tagbot.Service.models;
using TagBot.App.Properties;
using TagBot.Service;

namespace TagBot.App
{
    public partial class frmPreferences : Form
    {
        public frmMain frmMain;
        private ShowSearchResponseContract _dummyShow;
        private Track _dummyTrack;
        Service.Formatter formatter = new Service.Formatter(Settings.Default.customDateFormatter);

        public frmPreferences()
        {
            InitializeComponent();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            _dummyShow = new ShowSearchResponseContract()
            {
                City = "Camden",
                State = "NJ",
                Venue = "Susquehanna Bank Center",
                Date = "2009-09-19",
            };
            
            _dummyTrack = new Track()
            {
                TrackNumber = 1,
                TrackName = "Cornbread",
                Modifier = "",
            };

            formatter.customDateFormatter = Settings.Default.customDateFormatter;
            formatter.albumFormatterString = Settings.Default.albumFormatterString;
            formatter.titleFormatterString = Settings.Default.titleFormatterString;

            txtAlbumFormatter.Text = Settings.Default.albumFormatterString;
            txtCustomDateFormatter.Text = Settings.Default.customDateFormatter;
            txtTitleFormatter.Text = Settings.Default.titleFormatterString;

            lblAlbumFormatterDemo.Text = formatter.formatString(_dummyShow, FormatterType.Album);

            foreach (KeyValuePair<string, Service.FormatterInfo> entry in formatter.albumFormatterDict)
            {
                ListViewItem temp = new ListViewItem(entry.Key);
                temp.SubItems.Add(entry.Value.Description);
                lvAlbumFormatters.Items.Add(temp);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Settings.Default.albumFormatterString = txtAlbumFormatter.Text;
            Settings.Default.customDateFormatter = txtCustomDateFormatter.Text;
            Settings.Default.Save();
            frmMain.updateFormatterStrings();
            MessageBox.Show("Saved");
            this.Close();
        }

        private void txtAlbumFormatter_TextChanged(object sender, EventArgs e)
        {
            formatter.albumFormatterString = txtAlbumFormatter.Text;
            lblAlbumFormatterDemo.Text = formatter.formatString(_dummyShow, FormatterType.Album);
        }

        private void txtCustomDateFormatter_TextChanged(object sender, EventArgs e)
        {
            lblDateFormatterDemo.Text = DateTime.Parse(_dummyShow.Date).ToString(txtCustomDateFormatter.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings");
        }

        private void txtTitleFormatter_TextChanged(object sender, EventArgs e)
        {
            formatter.titleFormatterString = txtTitleFormatter.Text;
            _dummyTrack.Modifier = "";
            lblTitleFormatterDemo.Text = formatter.formatString(_dummyTrack, FormatterType.Track);
            _dummyTrack.Modifier = "aborted";
            lblTitleModifierFormatterDemo.Text = formatter.formatString(_dummyTrack, FormatterType.Track);
        }
    }
}
