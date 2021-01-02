using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class AlbumModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Genre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public PublisherModel Publisher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<SongModel> Songs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<PerformerModel> Performers { get; set; }

    }
}
