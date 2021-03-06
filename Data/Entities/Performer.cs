﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApplication.Data.Entities
{
    public class Performer
    {
        public int Id { get; set; }
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [DisplayName("Wiek")]
        public int Age { get; set; }
        [DisplayName("Główny styl")]
        public string MainStyle { get; set; }
        public ICollection<PerformerAlbum> PerformerAlbums { get; set; }
        [NotMapped]
        public string FullName { get => $"{FirstName}  {LastName}"; }
    }
}
