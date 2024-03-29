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
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class frmDebug : Form
    {
        public frmMain frmMain;

        public frmDebug()
        {
            InitializeComponent();
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.startingDirectory = null;
            Properties.Settings.Default.databaseLocation = null;
            Properties.Settings.Default.Save();
        }

        private void btnUpdateContention_Click(object sender, EventArgs e)
        {
            frmMain.ucMatchFiles.updateContention();
            rtfOriginalMetadata.Text = Utility.SerializeObject<Dictionary<string, AudioFileInfo>>(frmMain.originalMetadata, true);
            rtfProposedMetadata.Text = Utility.SerializeObject<Dictionary<string, AudioFileInfo>>(frmMain.proposedMetadata, true);
        }

        private void btnRefreshTextBoxes_Click(object sender, EventArgs e)
        {
            refreshTextBoxes();
        }

        public void refreshTextBoxes()
        {
            rtfSearchResult.Text = Utility.SerializeObject<ShowSearchResponseContract>(frmMain.showData, true);
            rtfOriginalMetadata.Text = Utility.SerializeObject<Dictionary<string, AudioFileInfo>>(frmMain.originalMetadata, true);
            rtfProposedMetadata.Text = Utility.SerializeObject<Dictionary<string, AudioFileInfo>>(frmMain.proposedMetadata, true);
        }

        private void frmDebug_Load(object sender, EventArgs e)
        {
            refreshTextBoxes();
        }

        private void btnRepairTrackNumbers_Click(object sender, EventArgs e)
        {
            return;
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = Settings.Default.databaseLocation;
            var showIds = Utility.DeserializeObject<List<int>>(sqlite.getShowIds());
            foreach (var id in showIds)
            {
                int trackNumber = 1;
                var showSongs = Utility.DeserializeObject<List<TrackRepair>>(sqlite.getShowSongsForRepair(id));
                foreach (var songs in showSongs)
                {
                    songs.TrackNumber = trackNumber;
                    sqlite.writeFixesToShowSongs(songs.ShowSongId, trackNumber);
                    trackNumber++;
                }
            }
        }
    }
}
