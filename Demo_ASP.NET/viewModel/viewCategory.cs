using Demo_ASP.NET.Models;
using System.ComponentModel.DataAnnotations;

namespace Demo_ASP.NET.viewModel
{
    public class viewCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string? CategoryName { get; set; }

        // Navigation property to Products
        public ICollection<product>? Products { get; set; }
    }
}
