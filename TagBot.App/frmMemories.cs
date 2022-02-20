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

namespace TagBot.App
{
    public partial class frmMemories : Form
    {
        public frmMain frmMain;

        public frmMemories()
        {
            InitializeComponent();
        }

        private void frmMemories_Load(object sender, EventArgs e)
        {
            pbBackground.Image = Image.FromFile(@"C:\Users\frank\Downloads\dmb bg.jpg");
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            using (Font myFont = new Font("Arial", 14))
            {
                pbBackground.CreateGraphics().DrawString(frmMain.showData.Date + " " + frmMain.showData.Venue + " - " + frmMain.showData.City + ", " + frmMain.showData.State, myFont, Brushes.Green, new Point(2, 2));
                int y = 40;
                foreach (Track song in frmMain.showData.Setlist)
                {
                    pbBackground.CreateGraphics().DrawString(song.TrackName, myFont, Brushes.Green, new Point(2, y));
                    y += 20;
                }
                //e.Graphics.DrawString("Hello .NET Guide!", );
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = Settings.Default.databaseLocation;
            List<List<SongPerformanceResponseContract>> songPerformances = new List<List<SongPerformanceResponseContract>>();
            foreach (Track song in frmMain.showData.Setlist)
            {
                List<SongPerformanceResponseContract> temp = Utility.DeserializeObject<List<SongPerformanceResponseContract>>(sqlite.getSongPerformances(song.TrackName));
                songPerformances.Add(temp);
            }

            foreach (List<SongPerformanceResponseContract> sp in songPerformances)
            {
                if (false) { }
            }
        }
    }
}
