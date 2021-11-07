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
using TagBot.App.Properties;
using TagBot.Service;

namespace TagBot.App
{
    public partial class frmPreferences : Form
    {
        public frmMain frmMain;
        private ShowSearchResponseContract _dummy;
        Service.Formatter formatter;

        public frmPreferences()
        {
            InitializeComponent();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            _dummy = new ShowSearchResponseContract()
            {
                City = "Camden",
                State = "NJ",
                Venue = "Susquehanna Bank Center",
                Date = "2009-09-19",
            };
            formatter = new Service.Formatter(_dummy, Settings.Default.customDateFormatter);

            txtAlbumFormatter.Text = Settings.Default.albumFormatterString;
            txtCustomDateFormatter.Text = Settings.Default.customDateFormatter;

            lblAlbumFormatterDemo.Text = formatter.formatString(txtAlbumFormatter.Text, FormatterType.Album);

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
            MessageBox.Show("Saved");
            this.Close();
        }

        private void txtAlbumFormatter_TextChanged(object sender, EventArgs e)
        {
            lblAlbumFormatterDemo.Text = formatter.formatString(txtAlbumFormatter.Text, FormatterType.Album);
        }

        private void txtCustomDateFormatter_TextChanged(object sender, EventArgs e)
        {
            lblDateFormatterDemo.Text = DateTime.Parse(_dummy.Date).ToString(txtCustomDateFormatter.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings");
        }
    }
}
