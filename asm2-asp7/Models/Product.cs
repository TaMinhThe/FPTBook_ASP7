using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asm2_asp7.Data
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

    }
}
