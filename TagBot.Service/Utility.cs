﻿using Newtonsoft.Json;
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
            bool gotDate = false;
            Regex regEx;
            Match date;
            DateTime parsedDateTime = new DateTime();

            Dictionary<string, Regex> formatStrings = new Dictionary<string, Regex>()
            {
                { "yyyy-MM-dd", new Regex(@"\d{4}\-\d{1,2}\-\d{1,2}") },
                { "yyyyMMdd", new Regex(@"\d{4}\d{1,2}\d{1,2}") },
                { "dd-MM-yyyy", new Regex(@"\d{1,2}\-\d{1,2}\-\d{4}") },
                { "ddMMyyyy", new Regex(@"\d{4}\d{1,2}\d{1,2}") },
                { "yy-MM-dd", new Regex(@"\d{2}\-\d{1,2}\-\d{1,2}") },
                { "yyMMdd", new Regex(@"\d{2}\d{1,2}\d{1,2}") },
            };

            int ct = 0;
            while (!gotDate && ct < (formatStrings.Count - 1))
            {
                regEx = formatStrings.ElementAt(ct).Value;
                string formatString = formatStrings.ElementAt(ct).Key;
                date = regEx.Match(name);
                gotDate = DateTime.TryParseExact(date.ToString(), formatString, new CultureInfo("en-US"), DateTimeStyles.None, out parsedDateTime);
                ct++;
            }

            DateCheckResponseContract response = new DateCheckResponseContract()
            {
                DirectoryName = name,
                Date = parsedDateTime.ToString("yyyy-MM-dd"),
                IsDate = parsedDateTime != DateTime.MinValue,
                DateFormat = formatStrings.ElementAt(ct - 1).Value,
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

        public static bool isSupportedAudio(string extension, bool mp3Mode = false)
        {
            List<string> supportedAudioFormats = new List<string>
            {
                ".flac",
            };

            if (mp3Mode)
            {
                supportedAudioFormats.Add(".mp3");
            }

            return supportedAudioFormats.Contains(extension);
        }

        public static bool isInfoFile(string extension)
        {
            List<string> supportedInfoFileFormats = new List<string>
            {
                ".txt",
                ".md5",
                ".ffp",
            };

            return supportedInfoFileFormats.Contains(extension);
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

        public static T DeserializeObject<T>(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        public static string SerializeObject<T>(T obj, bool format = false)
        {
            if (format)
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
            else
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            }
            
            
        }
    }
}
