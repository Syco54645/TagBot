using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagBot.Service.models
{
    public class DatabaseMeta
    {
        public bool Unload { get; set; } = false;
        public string Error { get; set; } = string.Empty;
        public string SchemaVersion { get; set; }
        public string Name { get; set; }
        public List<string> Artists { get; set; }
        public int ShowCount { get; set; }
        public int SongCount { get; set; }
        public string DatabaseRepo { get; set; }
        public string DataVersion { get; set; }
        public string DisplayDataVersion()
        {
            var dataVersion = DateTime.Parse(DataVersion);
            return dataVersion.ToString("yyyy.MM.dd.HH.mm.ss");
        }
    }
}
