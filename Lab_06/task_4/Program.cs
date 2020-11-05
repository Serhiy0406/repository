using System;
using System.Collections.Generic;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int a = int.Parse(Console.ReadLine());
            int h=0, m=0, s=0;
            for(int i = 0; i < a; i++)
            {
                try
                {
                    string[] s1 = Console.ReadLine().Split(';');
                    Song song = new Song(s1[0],s1[1],s1[2]);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                    string[] b = s1[2].Split(':');
                    s += int.Parse(b[1]);
                    if (s >= 60)
                    {
                        m += 1;
                        s = 60 - s;
                    }
                    m += int.Parse(b[0]);
                    if (m >= 60)
                    {
                        h += 1;
                        m = 60 - m;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Songs added : {songs.Count}");
            Console.WriteLine($"Playlist length : {h}h {m}m {s}s");
            Console.ReadKey();
        }
    }
}
