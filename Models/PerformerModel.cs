using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class PerformerModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Date of addition to database.
        /// </summary>
        [Required]
        public int Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string MainStyle { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public ICollection<AlbumModel> Albums { get; set; }
    }
}
