using System;
using System.Collections.Generic;

namespace Lecture_1_8.Library
{
    public class Album
    {
        private string title;
        private List<Song> albumList = new List<Song>();

        public Album(string title)
        {
            if (title == null)
            {
                // TODO Эксепшены не желательны 
                throw new ArgumentNullException("title");
            }

            this.title = title;
        }

        public Album(string title, List<Song> songs)
            : this(title)
        {
            if (songs == null)
            {
                throw new ArgumentNullException("songs");
            }

            albumList.AddRange(songs);
        }

        //public int SongCount
        //{
        //    get { return albumList.Count; }
        //}
        // TODO Если что так быстрее писать =) C# 6.0
        public int SongCount => albumList.Count;

        public Song this[int index]
        {
            get
            {
                if (index >= 0 && albumList.Count > index)
                    return albumList[index];

                throw new ArgumentOutOfRangeException("index");
            }
            set
            {
                if (index >= 0 && albumList.Count >= index)
                    albumList[index] = value;
                else if (index == albumList.Count)
                    albumList.Add(value);
                else
                    throw new ArgumentOutOfRangeException("index");
            }
        }

        public void AddSongToAlbum(Song song)
        {
            if (song == null)
                throw new ArgumentNullException("song");

            albumList.Add(song);
        }
    }
}