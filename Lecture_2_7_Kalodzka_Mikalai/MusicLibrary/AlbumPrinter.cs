using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MusicLibrary
{
    [Serializable]
    public class AlbumPrinter: Album
    {
        public void AlbumWriteIntoFileAndRead(string filePath, Album album)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fs, album);
            }


            using (FileStream fs2 = File.OpenRead(filePath))
            {
                album = (Album)formatter.Deserialize(fs2);
            }

            Byte[] array;
            using (MemoryStream ms = new MemoryStream())
            {
                formatter.Serialize(ms, album);
                array = ms.ToArray();
            }

            using (MemoryStream ms = new MemoryStream(array))
            {
                album = (Album)formatter.Deserialize(ms);
            }

            for (var i = 0; i < album.Tracks.Count; i++)
            {
                Console.WriteLine(album.Tracks[i]);
            }
        }        
    }
}
