﻿using System;
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
        Dictionary<string, string> artistTransformationDict;

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
                Artist = "dmb",
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
            formatter.artistTransformationDict = Utility.DeserializeObject<Dictionary<string, string>>(Settings.Default.artistTransformation);

            txtAlbumFormatter.Text = Settings.Default.albumFormatterString;
            txtCustomDateFormatter.Text = Settings.Default.customDateFormatter;
            txtTitleFormatter.Text = Settings.Default.titleFormatterString;

            lblAlbumFormatterDemo.Text = formatter.formatString(_dummyShow, FormatterType.Album);
            
            string formatterGuide = "";
            foreach (KeyValuePair<string, Service.FormatterInfo> entry in formatter.albumFormatterDict)
            {
                formatterGuide += entry.Key + " - " + entry.Value.Description + Environment.NewLine;
            }
            rtfAlbumFormatterGuide.Text = formatterGuide.TrimEnd(Environment.NewLine.ToCharArray());

            formatterGuide = "";
            foreach (KeyValuePair<string, Service.FormatterInfo> entry in formatter.titleFormatterDict)
            {
                formatterGuide += entry.Key + " - " + entry.Value.Description + Environment.NewLine;
            }
            rtfTitleFormatterGuide.Text = formatterGuide.TrimEnd(Environment.NewLine.ToCharArray());

            artistTransformationDict = Utility.DeserializeObject<Dictionary<string, string>>(Settings.Default.artistTransformation);
            lvArtists.Items.Clear();


            lvArtists.View = View.Details;
            lvArtists.HeaderStyle = ColumnHeaderStyle.None;
            lvArtists.FullRowSelect = true;
            if (lvArtists.Columns.Count == 0)
            {
                lvArtists.Columns.Add("", lvArtists.Width - SystemInformation.VerticalScrollBarWidth - 4);
            }
            foreach (string artist in frmMain.databaseMeta.Artists)
            {
                ListViewItem temp = new ListViewItem(artist);
                temp.Tag = artistTransformationDict[artist];
                lvArtists.Items.Add(temp);
            }
            txtArtistTransformation.Text = string.Empty;

            //lvArtists.Columns[0].Width = 20;//lvArtists.Width - 150 - SystemInformation.VerticalScrollBarWidth;
            //lvArtists.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            //lvArtists.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Settings.Default.albumFormatterString = txtAlbumFormatter.Text;
            Settings.Default.customDateFormatter = txtCustomDateFormatter.Text;
            Settings.Default.artistTransformation = Utility.SerializeObject<Dictionary<string, string>>(artistTransformationDict);
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

        private void lvArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvArtists.SelectedItems.Count > 0)
            {
                string artistAbbreviation = lvArtists.SelectedItems[0].Text;
                txtArtistTransformation.Text = artistTransformationDict.ContainsKey(artistAbbreviation) ? artistTransformationDict[artistAbbreviation] : string.Empty;
            }
        }

        private void txtArtistTransformation_TextChanged(object sender, EventArgs e)
        {
            if (lvArtists.SelectedItems.Count > 0)
            {
                string artistAbbreviation = lvArtists.SelectedItems[0].Text;
                if (!artistTransformationDict.ContainsKey(artistAbbreviation))
                {
                    artistTransformationDict.Add(artistAbbreviation, string.Empty);
                }
                artistTransformationDict[artistAbbreviation] = txtArtistTransformation.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (false) { }
        }
    }
}
