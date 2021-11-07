using System;
using System.Collections.Generic;
using System.Data.SQLite;

using Tagbot.Service.contracts;
using Tagbot.Service.models;
using TagBot.Service.models;

namespace Tagbot.Service
{
    public class Sqlite
    {
        public string databasePath { get; set; }// = AppDomain.CurrentDomain.BaseDirectory + "../";

        public string test(string date)
        {
            ShowSearchResponseContract response = new ShowSearchResponseContract();
            using (var connection = new SQLiteConnection("Data Source=" + databasePath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT show_id, date, venue, city, state
                    FROM show
                    WHERE date = $date
                ";
                string strippedDate = Utility.cleanDate(date);
                command.Parameters.AddWithValue("$date", strippedDate);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var show_id = reader.GetString(0);
                        response.ShowId = (int)reader["show_id"];
                        response.Date = (string)reader["date"];
                        response.Venue = (string)reader["venue"];
                        response.City = (string)reader["city"];
                        response.State = (string)reader["state"];

                        Console.WriteLine($"Hello, {show_id}!");
                    }
                }
            }
            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return stringResponse;
        }

        public string getShow(string date)
        {
            ShowSearchResponseContract response;
            string strippedDate = Utility.cleanDate(date);

            string showInfoJson = getShowInfo(strippedDate);
            response = Newtonsoft.Json.JsonConvert.DeserializeObject<ShowSearchResponseContract>(showInfoJson);

            string setlistJson = getShowSongs(response.ShowId);
            response.Setlist = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Track>>(setlistJson);

            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return stringResponse;
        }

        public string getShowInfo(string date)
        {
            ShowSearchResponseContract response = new ShowSearchResponseContract();
            //https://localhost:44341/api/values/dmb2009-09-19
            using (var connection = new SQLiteConnection("Data Source=" + databasePath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT show_id, date, venue, city, state, artist
                    FROM show
                    WHERE date = $date
                ";
                string strippedDate = Utility.cleanDate(date);
                command.Parameters.AddWithValue("$date", strippedDate);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        response.ShowId = (int)(long)reader["show_id"];
                        response.Date = (string)reader["date"];
                        response.Venue = (string)reader["venue"];
                        response.City = (string)reader["city"];
                        response.State = (string)reader["state"];
                        response.Artist = (string)reader["artist"];
                    }
                }
            }
            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return stringResponse;
        }

        public string getShowSongs(int showId)
        {
            List<Track> tracks = new List<Track>();
            using (var connection = new SQLiteConnection("Data Source=" + databasePath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT s.title, ss.track_number, ss.modifier
                    FROM song s
                    JOIN show_song ss
                    ON ss.song_id = s.song_id
                    WHERE ss.show_id = $showId
                    ORDER BY ss.track_number ASC
                ";
                command.Parameters.AddWithValue("$showId", showId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Track temp = new Track
                        {
                            TrackName = (string)reader["title"],
                            TrackNumber = (decimal)reader["track_number"],
                            Modifier = (string)reader["Modifier"],
                        };
                        tracks.Add(temp);
                    }
                }
            }
            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(tracks);
            return stringResponse;
        }

        public string getArtists()
        {
            List<string> artists = new List<string>();
            using (var connection = new SQLiteConnection("Data Source=" + databasePath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT DISTINCT(artist)
                    FROM show
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        artists.Add((string)reader["artist"]);
                    }
                }
            }
            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(artists);
            return stringResponse;
        }

        public string getDatabaseMeta()
        {
            DatabaseMeta meta = new DatabaseMeta();
            meta.Artists = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(getArtists());

            using (var connection = new SQLiteConnection("Data Source=" + databasePath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT meta_key, meta_value
                    FROM meta
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if ((string)reader["meta_key"] == "version")
                        {
                            meta.Version = (string)reader["meta_value"];
                        }
                    }
                }

                command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT COUNT(*) AS ct FROM song 
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        meta.SongCount = Convert.ToInt32(reader["ct"]);
                    }
                }

                command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT COUNT(*) AS ct FROM show
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        meta.ShowCount = Convert.ToInt32(reader["ct"]);
                    }
                }


            }
            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(meta);
            return stringResponse;
        }
    }
}
