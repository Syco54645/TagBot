using System;
using System.Collections.Generic;
using System.Text;

namespace Tagbot.Service
{
    public static class Utility
    {
        public static string cleanDate(string date)
        {
            // todo make this a bit better via probably regex
            return date.Replace("dmb", ""); ;
        }
    }
}
