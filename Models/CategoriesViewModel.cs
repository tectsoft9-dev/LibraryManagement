using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class CategoriesViewModel
    {
        [Key]
        public string CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
