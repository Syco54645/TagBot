using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagBot.App
{
    public partial class LabelToolTip : Label
    {
        private ToolTip _tt = new ToolTip();

        public LabelToolTip() : base()
        {
            _tt.AutoPopDelay = 1500;
            _tt.InitialDelay = 400;
            //_tt.IsBalloon = true;
            _tt.UseAnimation = true;
            _tt.UseFading = true;
            _tt.Active = true;
            this.MouseEnter += new EventHandler(this.ucLabel_MouseEnter);
        }

        private void ucLabel_MouseEnter(object sender, EventArgs ea)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                _tt.SetToolTip(this, this.Text);
                _tt.Show(this.Text, this.Parent);
            }
        }
    }
}
