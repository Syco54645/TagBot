using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tagbot.Service1;

namespace TagBot.App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtDate.Text = "dmb2009-09-19";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = AppDomain.CurrentDomain.BaseDirectory + "../../../";
            rtfResult.Text = sqlite.getShow(txtDate.Text);
        }
    }
}
