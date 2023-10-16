using Microsoft.AspNetCore.Identity;

namespace asm2_asp7.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? ProfilePicture {  get; set; }
    }
}
