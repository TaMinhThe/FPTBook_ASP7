using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asm2_asp7.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        public int Id { get; set; }
        [Required]
        public string? UserId { get; set; }
        [Required]
        public bool? IsDeleted { get; set; }   = false;


    }
}
