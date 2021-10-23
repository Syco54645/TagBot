using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TagBot.Service.contracts;

namespace Tagbot.Service
{
    public static class Utility
    {
        public static string cleanDate(string date)
        {
            // todo make this a bit better via probably regex
            return date.Replace("dmb", ""); ;
        }

        public static DateCheckResponseContract dateDir(string name)
        {
            var regEx = new Regex(@"\d{4}\-\d{1,2}\-\d{1,2}");
            var text = regEx.Replace(name, "");
            var date = regEx.Match(name);
            DateTime parsedDateTime;
            DateTime.TryParseExact(date.ToString(), "yyyy-MM-dd", new CultureInfo("en-US"), DateTimeStyles.None, out parsedDateTime);
            DateCheckResponseContract response = new DateCheckResponseContract()
            {
                DirectoryName = name,
                Date = date.ToString(),
                IsDate = parsedDateTime != DateTime.MinValue,
            };
            return response;
        }

        public static string getIconType(string extension)
        {
            string iconName;
            switch (extension)
            {
                case ".flac":
                    iconName = "audio";
                    break;
                case ".txt":
                case ".md5":
                case ".ffp":
                    iconName = "text";
                    break;
                default:
                    iconName = "file";
                    break;
            }

            return iconName;
        }

        public static bool isSupportedAudio(string extension)
        {
            List<string> supportedAudioFormats = new List<string>
            {
                ".flac",
            };

            return supportedAudioFormats.Contains(extension);
        }

        public static string UpperFirst(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Empty String");
            }
            str = str.ToLower();
            return str.First().ToString().ToUpper() + String.Join("", str.Skip(1));
        }
    }
}
