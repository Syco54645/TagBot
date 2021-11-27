using FlacLibSharp;
using TagLib;
using System;
using Tagbot.Service;
using TagBot.Service.models;

namespace TagBot.Service
{
    public static class Mp3
    {
        public static FlacFileInfo getMp3FileInfo(string path)
        {
            FlacFileInfo response = new FlacFileInfo();
            try
            {
                var tfile = TagLib.File.Create(path);
                response.Metadata.Artist = tfile.Tag.Performers[0];
                response.Metadata.Album = tfile.Tag.Album;
                response.Metadata.Date = tfile.Tag.Year.ToString();
                response.Metadata.Title = tfile.Tag.Title;
                response.Metadata.Tracknumber = tfile.Tag.Track.ToString();
                response.Metadata.Comment = tfile.Tag.Comment;
        
                response.Filename = System.IO.Path.GetFileName(path);
                var codecs = tfile.Properties.Codecs.GetEnumerator();
                codecs.MoveNext();
                response.Encoder = codecs.Current.Description;
                response.Bitrate = tfile.Properties.AudioBitrate.ToString();
                response.SampleRate = tfile.Properties.AudioSampleRate.ToString();

                response.Channels = tfile.Properties.AudioChannels.ToString();
                response.Size = new System.IO.FileInfo(path).Length;
                response.Duration = tfile.Properties.Duration.Seconds;
            }
            catch (Exception e)
            {
                if (false) { }
                // todo figure out a nice way to handle errors in the service.
            }
           
            return response;
        }

        public static bool writeTags(string path, Metadata metadata)
        {
            try
            {
                var tfile = TagLib.File.Create(path);
                tfile.Tag.Performers = new string[] { metadata.Artist };
                tfile.Tag.Album = metadata.Album;
                tfile.Tag.Year = Convert.ToUInt32(DateTime.Parse(metadata.Date).ToString("YYYY"));
                tfile.Tag.Title = metadata.Title;
                tfile.Tag.Track = Convert.ToUInt32(metadata.Tracknumber);
                tfile.Tag.Comment = metadata.Comment;
                tfile.Save();
            }
            catch (Exception e)
            {
                if (false) { }
                // todo figure out a nice way to handle errors in the service.
            }

            return true;
        }
    }
}
