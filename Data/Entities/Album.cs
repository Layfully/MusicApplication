using System;
using System.Collections.Generic;

namespace MusicApplication.Data.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.MinValue;
        public string Genre { get; set; }
        public int PublisherId { get; set; }
        public ICollection<Song> Songs { get; set; }
        public ICollection<Performer> Performers { get; set; }
    }
}
