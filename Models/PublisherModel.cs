using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class PublisherModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Date of addition to database.
        /// </summary>
        [Required]
        public string CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Country { get; set; }

        [Required]
        public ICollection<AlbumModel> Albums { get; set; }
        }
}
