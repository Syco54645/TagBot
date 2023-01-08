using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TagBot.Service.models
{
    public class DirectorySourceInfo
    {
        public string Path = string.Empty;
        public string Source = string.Empty;
        public Regex Format;
    }
}
