using System;
using System.Linq;
using TagBot.Service.models;

namespace TagBot.Service
{
    public static class Tagger
    {

        public static AudioFileInfo getFileInfo(string path)
        {
            AudioFileInfo response = new AudioFileInfo();
            try
            {
                using (TagLib.File file = TagLib.File.Create(path))
                {
                    response.Filename = System.IO.Path.GetFileName(path);
                    var codecs = file.Properties.Codecs.GetEnumerator();
                    codecs.MoveNext();
                    response.Encoder = file.Properties.BitsPerSample + " Bit " + codecs.Current.Description;
                    response.Bitrate = file.Properties.AudioBitrate.ToString();
                    response.SampleRate = file.Properties.AudioSampleRate.ToString();

                    response.Channels = file.Properties.AudioChannels.ToString();
                    response.Size = new System.IO.FileInfo(path).Length;
                    response.Duration = file.Properties.Duration.Seconds;

                    response.Metadata.Artist = file.Tag.AlbumArtists.FirstOrDefault();
                    response.Metadata.Album = file.Tag.Album;
                    response.Metadata.Title = file.Tag.Title;
                    response.Metadata.Tracknumber = file.Tag.Track.ToString();
                    response.Metadata.Comment = file.Tag.Comment;

                    var custom = (TagLib.Ogg.XiphComment)file.GetTag(TagLib.TagTypes.Xiph);
                    string[] dateField = custom.GetField("Date");

                    response.Metadata.Date = dateField.FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
        }

        public static bool writeTags(string path, Metadata metadata)
        {
            try
            {
                using (TagLib.File file = TagLib.File.Create(path))
                {

                    // Update the fields

                    var custom = (TagLib.Ogg.XiphComment)file.GetTag(TagLib.TagTypes.Xiph);
                    custom.SetField("Date", new string[] { metadata.Date });
                    file.Tag.Performers = new string[] { metadata.Artist };
                    file.Tag.AlbumArtists = new string[] { metadata.Artist };
                    file.Tag.Album = metadata.Album;
                    
                    file.Tag.Title = metadata.Title;
                    file.Tag.Track = Convert.ToUInt32(metadata.Tracknumber);
                    file.Tag.Comment = metadata.Comment;

                    // Write the changes back to the file
                    file.Save();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return true;
        }
    }
}
