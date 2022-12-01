using System;
using System.Collections.Generic;
using System.Text;

namespace Tagbot.Service.models
{
    public class Track
    {
        private string _modifier;
        public decimal TrackNumber { get; set; }
        public string TrackName { get; set; }
        public string Modifier
        {
            get
            {
                if (_modifier.ToLower()  == "segue")
                {
                    return ">";
                }
                return _modifier;
            }
            set { _modifier = value; }
        }
    }
}
