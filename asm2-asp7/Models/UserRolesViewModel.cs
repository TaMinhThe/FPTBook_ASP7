using System.ComponentModel.DataAnnotations;

namespace asm2_asp7.Models
{
    public class UserRolesViewModel
    {
        [Key]
        public string UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public IEnumerable<string>? Roles { get; set; }
    }
}
