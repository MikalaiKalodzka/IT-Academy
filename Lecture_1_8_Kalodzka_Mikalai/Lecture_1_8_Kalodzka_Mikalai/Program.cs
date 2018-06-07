using System;
using Lecture_1_8.Library;

namespace Lecture_1_8_Kalodzka_Mikalai
{
    class Program
    {
        static Album album = new Album("A Head Full Of Dreams");

        static void Main(string[] args)
        {
            

            Song song0 = new Song("Colour Spectrum", new TimeSpan(0, 01, 00));
            Song song1 = new Song("A Head Full Of Dreams", new TimeSpan(0, 03, 43));
            Song song2 = new Song("Up-Up", new TimeSpan(0, 06, 45));
            Song song3 = new Song("Hymn For The Weekend", new TimeSpan(0, 04, 18));
            Song song4 = new Song("Adventure Of The Lifetime", new TimeSpan(0, 04, 23));

            //album[0] = song0;
            //album[1] = song1;
            //album[2] = song2;
            //album[3] = song3;
            //album[4] = song4;

            album.AddSongToAlbum(song0);
            album.AddSongToAlbum(song1);
            album.AddSongToAlbum(song2);
            album.AddSongToAlbum(song3);
            album.AddSongToAlbum(song4);


            Play();

            Console.WriteLine();
            Console.WriteLine();

            Play(1);
            Console.WriteLine();
            Console.WriteLine();

            Play(0, 2);

            Console.ReadKey();
        }

        static void Play()
        {
            // TODO Дублирование кода
            Play(0, album.SongCount - 1);
            //for (int index = 0; index < album.SongCount; index++)
            //{
            //    Console.WriteLine($"{index + 1}. {album[index]}");
            //}
        }

        static void Play(int startIndex)
        {
            Play(startIndex, album.SongCount - 1);
            //if (startIndex < 0 || startIndex >= album.SongCount)
            //{
            //    throw new ArgumentOutOfRangeException("startIndex");
            //}
            //for (int index = startIndex; (index >= startIndex && index < album.SongCount); index++)
            //{
            //    Console.WriteLine($"{index + 1}. {album[index]}");
            //}
        }

        static void Play(int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= album.SongCount || startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException("startIndex");
            }

            if (endIndex < 0 || endIndex >= album.SongCount)
            {
                throw new ArgumentOutOfRangeException("endIndex");
            }

            for (int index = startIndex; (index >= startIndex && index <= endIndex); index++)
            {
                Console.WriteLine($"{index + 1}. {album[index]}");
            }
        }

    }
}
