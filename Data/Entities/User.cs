using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MusicApplication.Data.Entities
{
    public class User : IdentityUser
    {
        [Display(Name = "Imię")]
        [Required]
        [PersonalData]
        public string FirstName { get; set; }
        [Display(Name =  "Nazwisko")]
        [Required]
        [PersonalData]
        public string LastName { get; set; }
        [Display(Name = "Data utworzenia konta")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        [Display(Name = "Zdjęcie profilowe")]
        public byte[] ProfilePicture { get; set; }
    }
}
