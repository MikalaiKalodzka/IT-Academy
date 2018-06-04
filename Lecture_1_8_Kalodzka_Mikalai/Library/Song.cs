using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_8.Library
{
    public class Song
    {
        private string title;

        private TimeSpan length;
        

        public Song(string songTitle,  TimeSpan songLength)
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
