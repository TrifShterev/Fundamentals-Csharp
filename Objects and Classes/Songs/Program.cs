using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
        static void Main(string[] args)
        {
            int NumberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < NumberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split('_');

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string targetListType = Console.ReadLine();
            if (targetListType=="all")
            {
                songs.ForEach(x => Console.WriteLine(x.Name));
            }
            else
            {
                songs.Where(x => x.TypeList == targetListType)
               .ToList()
               .ForEach(x => Console.WriteLine(x.Name));
            }
            
           

        }
    }
}
