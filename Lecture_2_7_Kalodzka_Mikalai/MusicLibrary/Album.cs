using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace MusicLibrary
{
    [Serializable]
   
    public class Album: ISerializable
    {
        public string Title { get; set; }
        
        public List<Track> Tracks = new List<Track>();

        public Album()
        {

        }

        public Album(string title)
        {
            Title = title;
        }

        public Album(string title, List<Track> tracks)
        {
            Title = title;
            Tracks = tracks;
        }

        public void AddTrack(Track newTrack)
        {
            if (newTrack == null)
                throw new ArgumentNullException("The track is null.");
            
            if(Tracks.Any(track => Equals(newTrack)))
                throw new Exception("The track is already exists.");

            Tracks.Add(newTrack);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("Tracks", Tracks);
        }

        public Album(SerializationInfo info, StreamingContext context)
        {
            Title = (string)info.GetValue("Title", typeof(string));
            Tracks = (List<Track>)info.GetValue("Tracks", typeof(List<Track>));
        }        
    }
}
