using Microsoft.AspNetCore.Identity;


namespace NOA_Library.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
