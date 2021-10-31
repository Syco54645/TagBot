using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagBot.App
{
    public partial class frmDebug : Form
    {
        private string  _showData;
        public string ShowData 
        { 
            get 
            {
                return _showData;
            } 
            set 
            { 
                if (value != null)
                {
                    _showData = value;
                    rtfResult.Text = value;
                }
            } 
        }
        
        private string _originalMetadata;
        public string originalMetadata
        {
            get
            {
                return _originalMetadata;
            }
            set
            {
                if (value != null)
                {
                    _originalMetadata = value;
                    rtfOriginal.Text = value;
                }
            }
        }

        private string _proposedMetadata;
        public string proposedMetadata
        {
            get
            {
                return _proposedMetadata;
            }
            set
            {
                if (value != null)
                {
                    _proposedMetadata = value;
                    rtfProposed.Text = value;
                }
            }
        }

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
    }
}
