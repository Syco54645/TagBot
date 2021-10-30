using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagBot.Service.models
{
    public class DatabaseMeta
    {
        public string Version { get; set; }
        public List<string> Artists { get; set; }
    }
}
