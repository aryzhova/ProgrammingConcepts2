using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    class PhotoAlbum
    {
        public string albumName;
        public string pathToAlbum;
        public List<Photo> listOfPhotos;

        internal void Save(string path)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                pathToAlbum = path;
                writer.WriteLine($"{albumName}");
                if (listOfPhotos != null)
                {
                    foreach (Photo photo in listOfPhotos)
                    {
                        writer.WriteLine(photo.PathToPhoto);
                        writer.WriteLine(photo.Description);
                    }
                }
            }
        }

        internal void Open(string path)
        {
            pathToAlbum = path;
            using (StreamReader reader = new StreamReader(pathToAlbum))
            {
                albumName = reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    Photo photo = new Photo(reader.ReadLine());
                    photo.Description = reader.ReadLine();
                    listOfPhotos.Add(photo);
                }
            }
        }
    }
}
