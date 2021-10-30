--
-- File generated with SQLiteStudio v3.3.3 on Sat Oct 30 19:28:28 2021
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: meta
CREATE TABLE meta (
    meta_id    INTEGER       PRIMARY KEY AUTOINCREMENT,
    meta_key   VARCHAR (200),
    meta_value VARCHAR (200) 
);


-- Table: show
CREATE TABLE show (
    show_id            INTEGER       PRIMARY KEY AUTOINCREMENT,
    date               STRING,
    venue              VARCHAR (500),
    city               VARCHAR (500),
    state              VARCHAR (100),
    date_last_modified INTEGER       DEFAULT (datetime('now') ),
    artist             VARCHAR (50) 
);


-- Table: show_song
CREATE TABLE show_song (
    show_song_id       INTEGER       PRIMARY KEY AUTOINCREMENT,
    show_id            INTEGER       REFERENCES show (show_id),
    song_id            INTEGER       REFERENCES song (song_id),
    track_number       DECIMAL,
    date_last_modified INTEGER       DEFAULT (datetime('now') ),
    modifier           VARCHAR (200) 
);


-- Table: song
CREATE TABLE song (
    song_id            INTEGER       PRIMARY KEY AUTOINCREMENT,
    title              VARCHAR (500),
    date_last_modified INTEGER       DEFAULT (datetime('now') ) 
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;


--
-- File generated with SQLiteStudio v3.3.3 on Sat Oct 30 19:29:53 2021
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: meta
CREATE TABLE meta (
    meta_id    INTEGER       PRIMARY KEY AUTOINCREMENT,
    meta_key   VARCHAR (200),
    meta_value VARCHAR (200) 
);

INSERT INTO meta (
                     meta_id,
                     meta_key,
                     meta_value
                 )
                 VALUES (
                     1,
                     'version',
                     '1.0.0'
                 );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
