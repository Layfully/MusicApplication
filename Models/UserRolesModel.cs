using System.Collections.Generic;
using System.ComponentModel;

namespace MusicApplication.Models
{
    public class UserRolesModel
    {
        public string UserId { get; set; }
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [DisplayName("Nazwa użytkownika")]
        public string UserName { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Role")]
        public IEnumerable<string> Roles { get; set; }
    }
}
