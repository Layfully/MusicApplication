using System.Collections.Generic;

namespace MusicApplication.Data.Entities
{
    public class Performer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MainStyle { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
