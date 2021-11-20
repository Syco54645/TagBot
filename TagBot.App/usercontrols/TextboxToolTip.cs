using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagBot.App.usercontrols
{
    public partial class TextboxToolTip : TextBox
    {
        private TextBox _tb = new TextBox();
        private ToolTip _tt = new ToolTip();

        public TextboxToolTip() : base()
        {
            _tt.AutoPopDelay = 1500;
            _tt.InitialDelay = 400;
            //_tt.IsBalloon = true;
            _tt.UseAnimation = true;
            _tt.UseFading = true;
            _tt.Active = true;
            this.MouseEnter += new EventHandler(this.ucTextBox_MouseEnter);
        }

        private void ucTextBox_MouseEnter(object sender, EventArgs ea)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                _tt.SetToolTip(this, this.Text);
                _tt.Show(this.Text, this.Parent);
            }
        }

    }
}
