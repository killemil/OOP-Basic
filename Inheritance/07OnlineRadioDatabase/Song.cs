namespace _07OnlineRadioDatabase
{
    using System;

    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, string duration)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SetLength(duration);
        }

        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }

        public int Minutes
        {
            get
            { return this.minutes; }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }


        public string SongName
        {
            get
            {
                return this.songName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                this.songName = value;
            }
        }

        public string ArtistName
        {
            get
            {
                return this.artistName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artistName = value;
            }
        }

        private void SetLength(string length)
        {
            string[] lenTokens = length.Split(':');

            int minutes;
            int seconds;

            try
            {
                minutes = int.Parse(lenTokens[0]);
                seconds = int.Parse(lenTokens[1]);

            }
            catch (Exception)
            {
                throw new InvalidSongLengthException();
            }

            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}
