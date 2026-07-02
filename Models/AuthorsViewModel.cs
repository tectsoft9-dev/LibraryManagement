using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class AuthorsViewModel
    {
        [Key]
        public string AuthorId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
