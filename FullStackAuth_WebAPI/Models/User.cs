using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FullStackAuth_WebAPI.Models
{
    public class User : IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserId { get; set; }
    }
}
