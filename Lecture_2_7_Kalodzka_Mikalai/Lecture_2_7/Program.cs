using System;
using System.Collections.Generic;

using MusicLibrary;

namespace Lecture_2_7_Kalodzka_Mikalai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Track> albumTracks1 = new List<Track>();
            Album album1 = new Album("A Head Full of Dreams", albumTracks1);
            
            Track track0 = new Track("A Head Full of Dreams", "Colour Spectrum", new TimeSpan(0, 01, 00));
            Track track1 = new Track("A Head Full of Dreams", "A Head Full Of Dreams", new TimeSpan(0, 03, 43));
            Track track2 = new Track("A Head Full of Dreams", "Up-Up", new TimeSpan(0, 06, 45));
            Track track3 = new Track("A Head Full of Dreams","Hymn For The Weekend", new TimeSpan(0, 04, 18));
            Track track4 = new Track("A Head Full of Dreams","Adventure Of The Lifetime", new TimeSpan(0, 04, 23));

            var songs = new List<Track>();
            songs.Add(track0);
            songs.Add(track1);
            songs.Add(track2);
            songs.Add(track3);
            songs.Add(track4);

            foreach (var song in songs)
            {
                try
                {
                    album1.AddTrack(song);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); ;
                }
            }

            List<Track> albumTrack2 = new List<Track>();
            Album album2 = new Album("Viva La Vida", albumTrack2);

            Track track11 = new Track("Viva La Vida", "Life In Technicolor", new TimeSpan(0, 2, 31));
            Track track12 = new Track("Viva La Vida", "Cemetries Of London", new TimeSpan(0, 3, 20));
            Track track13 = new Track("Viva La Vida", "Lovers In Japan", new TimeSpan(0, 6, 50));
            Track track14 = new Track("Viva La Vida", "Viva La Vida", new TimeSpan(0, 4, 04));
            Track track15 = new Track("Viva La Vida", "Lost?", new TimeSpan(0, 3, 54));
            
            songs.Clear();
            songs.Add(track11);
            songs.Add(track12);
            songs.Add(track13);
            songs.Add(track14);
            songs.Add(track15);

            foreach (var song in songs)
            {
                try
                {
                    album2.AddTrack(song);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); ;
                }
            }

            AlbumPrinter albumPrinter = new AlbumPrinter();

            albumPrinter.AlbumWriteIntoFileAndRead(@"D:\Downloads\album.xml", album1);

            albumPrinter.AlbumWriteIntoFileAndRead(@"D:\Downloads\album.xml", album2);

            Console.ReadKey();
        }
    }
}
