using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    class Photo
    {   string pathToPhoto;
        public string PathToPhoto
        {
            get => pathToPhoto;
        }
        string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Photo(string path)
        {
            pathToPhoto = path;
        }
    }
}
