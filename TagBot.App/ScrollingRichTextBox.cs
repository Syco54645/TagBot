using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagBot.App
{
    class ScrollingRichTextBox : RichTextBox
    {
        [Browsable(true)]
        [Category("Custom Behavior")]
        [Description("RTF that scrolls to the bottom")]
        [DisplayName("ScrollingRichTextBox")]

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            uint Msg,
            IntPtr wParam,
            IntPtr LParam);

        private const int _WM_VSCROLL = 277;
        private const int _SB_BOTTOM = 7;

        /// <summary>
        /// Scrolls to the bottom of the RichTextBox.
        /// </summary>
        public void ScrollToBottom()
        {
            SendMessage(Handle, _WM_VSCROLL, new IntPtr(_SB_BOTTOM), new IntPtr(0));
        }
    }
}
