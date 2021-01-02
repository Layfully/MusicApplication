using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class SongModel
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
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public float Length { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public AlbumModel Album { get; set; }

    }
}
