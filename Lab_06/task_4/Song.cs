using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using task_4.forSongExeption;
using task_4.forSongLengthExeption;

namespace task_4
{
    class Song
    {
        private string artist;
        private string songname;
        private string length;
        public string Artist 
        {
            get { return artist; }
            set
            {
                if(value.Length<3 || value.Length > 20)
                {
                    throw new InvalidArtistNameExeption("Artist name should be between 3 and 20 symbols.");
                }
                else { artist = value; }
            }
        }
        public string SongName 
        {
            get { return songname; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameExeption("Song name should be between 3 and 30 symbols.");
                }
                else{ songname = value; }
            }
        }
        public string Length
        {
            get { return length; }
            set
            {
                string[] s = value.Split(':');
                if (int.Parse(s[1]) < 0 || int.Parse(s[1]) > 59)
                {
                    throw new InvalidSongSecondsExeption("Song seconds should be between 0 and 59.");
                }
                else { length = value; }
                if (int.Parse(s[0]) < 0 || int.Parse(s[0]) > 14)
                {
                    throw new InvalidSongMinutesExeption("Song minutes should be between 0 and 14.");
                }
                else { length = value; }
            }
        }
        public Song (string artist, string songname, string length)
        {
            Artist = artist;
            SongName = songname;
            Length = length;
        }
    }
}
