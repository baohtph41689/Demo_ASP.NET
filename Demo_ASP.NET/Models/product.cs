using System.ComponentModel.DataAnnotations;

namespace Demo_ASP.NET.Models
{
    public class product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Range(0, 100000)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        // Navigation property to Category
        public category? Category { get; set; }
    }
}
