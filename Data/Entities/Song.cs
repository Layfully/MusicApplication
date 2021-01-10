using System.ComponentModel;

namespace MusicApplication.Data.Entities
{
    public class Song
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Adres URL")]
        public string Url { get; set; }
        [DisplayName("Długość")]
        public float Length { get; set; }
        [DisplayName("Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
