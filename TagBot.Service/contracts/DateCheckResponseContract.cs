using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagBot.Service.contracts
{
    public class DateCheckResponseContract
    {
        public string DirectoryName { get; set; }
        public string Date { get; set; }
        public bool IsDate { get; set; } = false;
    }
}
