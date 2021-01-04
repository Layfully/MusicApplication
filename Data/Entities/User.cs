using System;
using Microsoft.AspNetCore.Identity;

namespace MusicApplication.Data.Entities
{
    public class User : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
