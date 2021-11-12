using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagBot.Service.models
{
    public class DatabaseMeta
    {
        public string SchemaVersion { get; set; }
        public List<string> Artists { get; set; }
        public int ShowCount { get; set; }
        public int SongCount { get; set; }
    }
}
