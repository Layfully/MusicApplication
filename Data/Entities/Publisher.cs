using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MusicApplication.Data.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Data utworzenia")]
        public DateTime CreationDate { get; set; }
        [DisplayName("Lokalizacja")]
        public string Location { get; set; }
        [DisplayName("Kraj")]
        public string Country { get; set; }
        public ICollection<Album> Albums { get; set; }

    }
}
