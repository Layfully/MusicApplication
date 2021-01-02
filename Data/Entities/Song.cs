namespace MusicApplication.Data.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public float Length { get; set; }
        public int AlbumId { get; set; }
    }
}
