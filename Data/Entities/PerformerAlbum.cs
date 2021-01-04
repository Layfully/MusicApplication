using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Data.Entities
{
    public class PerformerAlbum
    {
        public int PerformerId { get; set; }
        public Performer Performer { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
