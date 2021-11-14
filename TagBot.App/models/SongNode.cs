using Aga.Controls.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagBot.App.models
{
    public class SongNode : Node
    {
        public string Filename { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Title { get; set; }
        public override string Text { get { return (Index + 1).ToString() + " - " + Filename; } }
        public string Tracknumber { get; set; }
    }
}
