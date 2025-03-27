using Microsoft.AspNetCore.Identity;

namespace DuAnNhom1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }

}
