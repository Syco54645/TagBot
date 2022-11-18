using System;
using System.Collections.Generic;
using System.Text;

namespace Tagbot.Service.models
{
    public class TrackRepair
    {
        public int ShowSongId { get; set; }
        public decimal TrackNumber { get; set; }
        public string TrackName { get; set; }
        public string Modifier { get; set; }
    }
}
