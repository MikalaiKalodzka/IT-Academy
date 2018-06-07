using System;

namespace Lecture_1_8.Library
{
    public class Song
    {
        // TODO Readonly так как менять не планируете
        private string title;

        private TimeSpan length;


        public Song(string songTitle, TimeSpan songLength)
        {
            title = songTitle;
            length = songLength;
        }

        public override string ToString()
        {
            return $"{title} - {length}";
        }
    }
}