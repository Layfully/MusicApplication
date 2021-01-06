using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MusicApplication.Data.Entities
{
    public class Album
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Data wydania")]
        public DateTime ReleaseDate { get; set; } = DateTime.MinValue;
        [DisplayName("Gatunek muzyczny")]
        public string Genre { get; set; }
        [DisplayName("Wydawca")]
        public int PublisherId { get; set; }
        public ICollection<Song> Songs { get; set; }
        public ICollection<PerformerAlbum> PerformerAlbums { get; set; }
    }
}
