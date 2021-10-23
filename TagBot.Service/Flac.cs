using FlacLibSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tagbot.Service;
using TagBot.Service.models;

namespace TagBot.Service
{
    public class Flac
    {
        public FlacFileInfo getFlacFileInfo(string path)
        {
            FlacFileInfo response = new FlacFileInfo();
            try
            {
                using (FlacFile file = new FlacFile(path))
                {
                    response.Encoder = file.StreamInfo.BitsPerSample.ToString() + " bit flac";
                    response.Bitrate = file.StreamInfo.BitsPerSample.ToString();
                    response.SampleRate = file.StreamInfo.SampleRateHz.ToString() + " Hz";

                    response.Channels = file.StreamInfo.Channels.ToString();
                    response.Size = new System.IO.FileInfo(path).Length;
                    response.Duration = file.StreamInfo.Duration;
                    
                    var vorbisComment = file.VorbisComment;
                    if (vorbisComment != null)
                    {
                        foreach (var tag in vorbisComment)
                        {
                            response.Metadata[Utility.UpperFirst(tag.Key)] = tag.Value;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // todo figure out a nice way to handle errors in the service.
            }
           
            return response;
        }
    }
}
