﻿using FlacLibSharp;
using System;
using Tagbot.Service;
using TagBot.Service.models;

namespace TagBot.Service
{
    public static class Flac
    {
        public static FlacFileInfo getFlacFileInfo(string path)
        {
            FlacFileInfo response = new FlacFileInfo();
            try
            {
                using (FlacFile file = new FlacFile(path))
                {
                    response.Filename = System.IO.Path.GetFileName(path);
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

        public static bool writeFlacTags(string path, Metadata metadata)
        {
            try
            {
                using (FlacFile flac = new FlacFile(path))
                {
                    var comment = flac.VorbisComment;
                    if (comment == null)
                    {
                        // Create a new vorbis comment metadata block
                        comment = new VorbisComment();
                        // Add it to the flac file
                        flac.Metadata.Add(comment);
                    }

                    // Update the fields
                    comment.Artist.Value = metadata.Artist;
                    comment.Album.Value = metadata.Album;
                    comment.Date.Value = metadata.Date;
                    comment.Title.Value = metadata.Title;
                    comment.TrackNumber.Value = metadata.Tracknumber;

                    // Write the changes back to the FLAC file
                    flac.Save();
                }
            }
            catch (Exception e)
            {
                // todo figure out a nice way to handle errors in the service.
            }

            return true;
        }
    }
}
