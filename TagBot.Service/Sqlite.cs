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
            List<ShowSearchResponseContract> response;
            string strippedDate = Utility.cleanDate(date);

            string showInfoJson = getShowInfo(strippedDate);
            response = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ShowSearchResponseContract>>(showInfoJson);

            foreach (var show in response)
            {
                string setlistJson = getShowSongs(show.ShowId);
                show.Setlist = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Track>>(setlistJson);
            }

            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return stringResponse;
        }

        public string getShowInfo(string date)
        {
            List<ShowSearchResponseContract> response = new List<ShowSearchResponseContract>();
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
                        ShowSearchResponseContract temp = new ShowSearchResponseContract
                        {
                            ShowId = (int)(long)reader["show_id"],
                            Date = (string)reader["date"],
                            Venue = (string)reader["venue"],
                            City = (string)reader["city"],
                            State = (string)reader["state"],
                            Artist = (string)reader["artist"],
                        };
                        response.Add(temp);
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

        public string getSongPerformances(string songName)
        {
            List<SongPerformanceResponseContract> songPerformances = new List<SongPerformanceResponseContract>();

            using (var connection = new SQLiteConnection("Data Source=" + databasePath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                SELECT shw.* 
                FROM song sng
                JOIN show_song ss
                ON sng.song_id = ss.song_id
                JOIN show shw
                ON shw.show_id = ss.show_id
                WHERE title = $songName
                ORDER BY date desc
            ";

                command.Parameters.AddWithValue("$songName", songName);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SongPerformanceResponseContract temp = new SongPerformanceResponseContract()
                        {
                            Date = (string)reader["date"],
                            Venue = (string)reader["venue"],
                            City = (string)reader["city"],
                            State = (string)reader["state"],
                            Artist = (string)reader["artist"],
                        };
                        songPerformances.Add(temp);
                    }
                }
            }
            
            
            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(songPerformances);
            return stringResponse;
        }


        public string getDatabaseMeta(string requiredSchemaVersion)
        {
            DatabaseMeta meta = new DatabaseMeta();
            try
            {
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
                            /*string metaKey = "";
                            switch ((string)reader["meta_key"])
                            {
                                case "schema_version":
                                    metaKey = "SchemaVersion";
                                    break;
                                case "database_repo":
                                    metaKey = "DatabaseRepo";
                                    break;
                                case "database_name":
                                    metaKey = "Name";
                                    break;
                            }
                            meta[metaKey] = (string)reader["meta_value"];*/
                            if ((string)reader["meta_key"] == "schema_version")
                            {
                                meta.SchemaVersion = (string)reader["meta_value"];
                            }
                            if ((string)reader["meta_key"] == "database_repo")
                            {
                                meta.DatabaseRepo = (string)reader["meta_value"];
                            }
                            if ((string)reader["meta_key"] == "database_name")
                            {
                                meta.Name = (string)reader["meta_value"];
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

                    command = connection.CreateCommand();
                    command.CommandText =
                    @"
                        SELECT database_last_modified FROM database_last_modified
                    ";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            meta.DataVersion = (string)reader["database_last_modified"];
                        }
                    }
                }

                if (meta.SchemaVersion != requiredSchemaVersion)
                {
                    meta.Unload = true;
                    meta.Error = "Reqired Schema Version: " + requiredSchemaVersion + Environment.NewLine + "Schema Version: " + meta.SchemaVersion;
                    meta.Error += Environment.NewLine + Environment.NewLine + "This typically happens when you need to update the application or the database. Please download both and try again.";
                    meta.Error += Environment.NewLine + Environment.NewLine + "If the issue persists open a bug against both TagBot and the selected database.";
                }
            }
            catch (Exception e)
            {
                meta.Unload = true;
                meta.Error = e.Message;
            }
            string stringResponse = Newtonsoft.Json.JsonConvert.SerializeObject(meta);
            return stringResponse;
        }
    }
}
