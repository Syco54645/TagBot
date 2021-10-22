using System;
using System.Collections.Generic;
using System.Text;

namespace Tagbot.Service.models
{
    class Show
    {

        public int ShowId { get; set; }
        public string Date { get; set; }
        public string Venue { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<Track> Setlist { get; set; } = new List<Track>();
    }
}
