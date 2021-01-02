using System;
using System.Collections.Generic;

namespace MusicApplication.Data.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public ICollection<Album> Albums { get; set; }

    }
}
