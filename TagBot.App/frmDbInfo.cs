using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class frmDbInfo : Form
    {
        public frmMain frmMain;
        public frmDbInfo()
        {
            InitializeComponent();
        }

        private void frmDbInfo_Load(object sender, EventArgs e)
        {

        }

        public void displayDbMeta(DatabaseMeta databaseMeta)
        {
            txtLoadedDatabase.Text = Properties.Settings.Default.databaseLocation;
            txtLoadedDatabase.AppendText("");
            lblLoadedDatabaseVersion.Text = databaseMeta.Version;
            lblSongCount.Text = databaseMeta.SongCount.ToString();
            lblShowCount.Text = databaseMeta.ShowCount.ToString();
            lblArtistCount.Text = databaseMeta.Artists.Count.ToString();

            foreach (string artist in databaseMeta.Artists)
            {
                lbArtists.Items.Add(artist);
            }
        }
    }
}
