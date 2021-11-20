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

        public TextboxToolTip() : base()
        {
            /*_tb.AutoPopDelay = 1500;
            _tb.InitialDelay = 400;
            //_tt.IsBalloon = true;
            _tb.UseAnimation = true;
            _tb.UseFading = true;
            _tb.Active = true;*/
            this.MouseEnter += new EventHandler(this.ucTextBox_MouseEnter);
        }

        private void ucTextBox_MouseEnter(object sender, EventArgs ea)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this, this.Text);
                tt.Show(this.Text, this.Parent);
            }
        }

    }
}
