using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        private static void Main(string[] args) {
            var songs = new Song[] {
            new Song("a", "AAA", 240),
            new Song("b", "BBB", 190),
            new Song("c", "CCC", 200)
        };
            PrintSongs(songs);
        }
        private static void PrintSongs(Song[] songs) {
            foreach(var song in songs) {
                Console.WriteLine(@"{0},{1},{2:m\:ss}",song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));

            }
        }
    }
}
