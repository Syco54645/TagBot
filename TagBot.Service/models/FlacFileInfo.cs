using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagBot.Service.models
{
    public class FlacFileInfo
    {
        public string Encoder { get; set; }
        public string Bitrate { get; set; }
        public string SampleRate { get; set; }
        public string Channels { get; set; }
        public long Size { get; set; }
        public long Duration { get; set; }
        public Metadata Metadata { get; set; } = new Metadata();
    }
}
