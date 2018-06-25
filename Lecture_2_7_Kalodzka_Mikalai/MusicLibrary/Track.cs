using System;
using System.Runtime.Serialization;

namespace MusicLibrary

{
    [Serializable]
    public class Track: ISerializable
    {
        public string AlbumTitle { get; set; }
        public string Title { get; set; }
        public TimeSpan Length { get; set; }

        public Track()
        {

        }

        public Track(string albumTitle, string title, TimeSpan length)
        {
            AlbumTitle = albumTitle;
            Title = title;
            Length = length;
        }

        public override string ToString()
        {
            return $"Album: {AlbumTitle} - Song: {Title} - Length: {Length}";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("AlbumTitle", AlbumTitle);
            info.AddValue("Title", Title);
            info.AddValue("Length", Length);
        }

        public Track(SerializationInfo info, StreamingContext context)
        {
            AlbumTitle = (string)info.GetValue("AlbumTitle", typeof(string));
            Title = (string)info.GetValue("Title", typeof(string));
            Length = (TimeSpan)info.GetValue("Length", typeof(TimeSpan));
        }
    }
}
