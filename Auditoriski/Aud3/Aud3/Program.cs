using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Song s = new Song("Bohemian Rapsody", 250, 4.8f);
                Song s1 = new Song("I want to break free", 280, 3.2f);
                Song s2 = new Song("The show must go on", 110, 1.3f);

                Album album = new Album();
                album.Name = "Queen";
                album.Year = 1984;
                album.AddSong(s);
                album.AddSong(s1);
                album.AddSong(s2);
                //Song bohemian = album.findSong("Bohemian Rapsody");
                s2.play();
                Console.WriteLine(album);
                Console.Read();
            }
            catch (SongNotFoundException s)
            {
                Console.WriteLine("The song was not found");
                Console.Read();

            }
            catch (Exception e)
            {
                Console.Read();
            }
        }
    }

    class Song
    {
        public string Name { get; set; }
        public float Rating { get; set; }
        public int Duration { get; set; }
        public Song()
        {

        }

        public Song(string name,int duration, float rating)
        {
            this.Name = name;
            this.Rating = rating;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return string.Format(" {0} - {1} ", Name, Duration);
        }

    }

    class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Song> Songs { get; set; }


        public Album()
        {
            Songs = new List<Song>();
        }
        public Album(string name, int year)
        {
            this.Name = name;
            this.Year = year;
            Songs = new List<Song>();
        }

        public void AddSong(string name, int duration, float rating)
        {
            Song song = new Song(name, duration, rating);
            Songs.Add(song);
        }

        public void AddSong(Song s)
        {
            Songs.Add(s);
        }

        public Song FindSong(string name)
        {
            foreach (Song song in Songs)
            {
                if (song.Name.Equals(Name, StringComparison.OrdinalIgnoreCase))
                    return song;
            }
            throw new SongNotFoundException(name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append("\n");
            sb.Append(Year);
            sb.Append("\n");
            sb.Append("Songs: \n");
            int i = 1;
            foreach(Song song in Songs)
            {
                sb.Append(string.Format("{0}. ", i++));
                sb.Append(song + "\n");
            }
            return sb.ToString();
        }
    }

    class SongNotFoundException : Exception
    {
        public SongNotFoundException(string name) : base(name)
        {
           
        }
    }
}
