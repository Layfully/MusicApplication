using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public ICollection<PerformerAlbum> PerformerAlbums { get; set; }

        [DisplayName("Zdjęcie okładki")]
        public byte[] Picture { get; set; }

        [NotMapped]
        [DisplayName("Artyści")]
        public IEnumerable<Performer> Performers
        {
            get => PerformerAlbums.Select(x => x.Performer);
            set => PerformerAlbums = value.Select(v => new PerformerAlbum()
            {
                PerformerId = v.Id
            }).ToList();
        }
    }
}
