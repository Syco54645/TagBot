using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Tagbot.Service.contracts;
using Tagbot.Service.models;
using TagBot.Service.models;

namespace TagBot.Service
{

    public class Formatter
    {
        public Dictionary<string, FormatterInfo> albumFormatterDict;
        public Dictionary<string, FormatterInfo> titleFormatterDict;
        public Dictionary<string, string> artistTransformationDict;
        private DirectorySourceInfo _directorySourceInfo { get; set; }
        public void setDirectorySourceInfo(string path, Regex format)
        {
            _directorySourceInfo = new DirectorySourceInfo();

            _directorySourceInfo.Path = path;
            _directorySourceInfo.Format = format;
            _directorySourceInfo.Source = susOutSource(path, format);
        }

        private ShowSearchResponseContract _showData;
        public ShowSearchResponseContract showData
        {
            get
            {
                return _showData;
            }
            set
            {
                _showData = value;
                
                string artistName = (artistTransformationDict.ContainsKey(showData.Artist) && !string.IsNullOrEmpty(artistTransformationDict[showData.Artist])) ? artistTransformationDict[showData.Artist] : showData.Artist;
                albumFormatterDict = new Dictionary<string, FormatterInfo>
                {
                    {"%d", new FormatterInfo("Format date in custom date format", formatDate(showData.Date.Trim()))},
                    {"%v", new FormatterInfo("Venue", showData.Venue.Trim())},
                    {"%c", new FormatterInfo("City", showData.City.Trim())},
                    {"%s", new FormatterInfo("State", showData.State.Trim())},
                    {"%a", new FormatterInfo("Short Artist Name", showData.Artist.Trim())},
                    {"%A", new FormatterInfo("Full Artist Name", artistName.Trim())},
                    {"%D", new FormatterInfo("Directory Name", _directorySourceInfo.Path.Trim())},
                    {"%S", new FormatterInfo("Source (experimental)", _directorySourceInfo.Source.Trim())},
                };
            }
        }

        private Track _track;
        public Track track 
        { 
            get 
            { 
                return _track; 
            } 
            set 
            {
                _track = value;
                titleFormatterDict = new Dictionary<string, FormatterInfo>
                {
                    {"%t", new FormatterInfo("Title", track.TrackName.Trim())},
                    {"%r", new FormatterInfo("Title with article at the end", moveArticleToEnd(track.TrackName.Trim()))},
                    {"%m", new FormatterInfo("Modifier", track.Modifier.Trim())},
                };
            } 
        }
        public string customDateFormatter;
        public string albumFormatterString;
        public string titleFormatterString;

        public Formatter(string customDateFormatter)
        {
            this.customDateFormatter = customDateFormatter;
        }

        public string susOutSource(string str, Regex dateFormat)
        {
            string dateRegexStr = dateFormat.ToString();

            var regex = new Regex("[a-z]*[A-Z]*" + dateRegexStr + ".?");
            string response = regex.Replace(str, string.Empty);
            return response;
        }
        
        public string moveArticleToEnd(string str)
        {
            if (str.StartsWith("The "))
            {
                //var temp = str.Split(' ').Join()
            }
            return str;
        }

        public string formatString(Track track, FormatterType formatterType)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            track.TrackName = textInfo.ToTitleCase(track.TrackName);
            this.track = track;
            string formatter = titleFormatterString;
            if (string.IsNullOrEmpty(track.Modifier))
            {
                // remove the %0 bit
                Regex rx = new Regex(@"\%0.*\%0");
                formatter = rx.Replace(formatter, string.Empty).Trim();
            }
            else if(track.Modifier == ">")
            {
                formatter = "%t %0%m%0";
                formatter = formatter.Replace("%0", string.Empty).Trim();
            }
            else
            {
                formatter = formatter.Replace("%0", string.Empty).Trim();
            }
            string response = titleFormatterDict.Aggregate(formatter, (current, value) => current.Replace(value.Key, value.Value.Value));
            return response;
        }
        #region Album Formatters
        public string formatString(ShowSearchResponseContract showData, FormatterType formatterType)
        {
            this.showData = showData;
            string formatter = albumFormatterString;
            if (string.IsNullOrEmpty(_directorySourceInfo.Source))
            {
                Regex rx = new Regex(@"\%0.*\%0");
                formatter = rx.Replace(formatter, string.Empty).Trim();
            }
            else
            {
                formatter = formatter.Replace("%0", string.Empty).Trim();
            }
            string response = albumFormatterDict.Aggregate(formatter, (current, value) => current.Replace(value.Key, value.Value.Value));
            return response;
        }

        public string formatDate(string str)
        {
            return DateTime.Parse(str).ToString(customDateFormatter);
        }
        #endregion
    }
    public class FormatterInfo
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public FormatterInfo(string desc, string val)
        {
            Description = desc;
            Value = val;
        }
    }

    public enum FormatterType
    {
        Album,
        Track
    }
}
