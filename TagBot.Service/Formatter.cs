using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tagbot.Service.contracts;

namespace TagBot.Service
{
    public class Formatter
    {
        public Dictionary<string, FormatterInfo> albumFormatterDict;
        public ShowSearchResponseContract showData;
        public string customDateFormatter;

        public Formatter(ShowSearchResponseContract sd, string customDateFormatter)
        {
            showData = sd;
            this.customDateFormatter = customDateFormatter;
            albumFormatterDict = new Dictionary<string, FormatterInfo>
            {
                {"%d", new FormatterInfo("Format date in custom date format", formatAlbumDCus(showData.Date.Trim()))},
                {"%v",  new FormatterInfo("Venue", showData.Venue.Trim())},
                {"%c",  new FormatterInfo("City", showData.City.Trim())},
                {"%s",  new FormatterInfo("State", showData.State.Trim())},
            };
        }

        public string formatString(string formatter, FormatterType formatterType)
        {
            Dictionary<string, FormatterInfo> formatterValues;
            switch (formatterType)
            {
                case FormatterType.Album:
                    formatterValues = albumFormatterDict;
                    break;
                default:
                    formatterValues = new Dictionary<string, FormatterInfo>();
                    break;
            }
            string response = formatterValues.Aggregate(formatter, (current, value) => current.Replace(value.Key, value.Value.Value));
            return response;
        }

        #region Album Formatters
        public string formatAlbumDCus(string str)
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
        Title
    }
}
