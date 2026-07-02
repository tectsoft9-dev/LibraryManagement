using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class BooksViewModel
    {
        [Key]
        public string BookId { get; set; }
        [Required]
        public string Title { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        [Required]
        [ForeignKey("Author")]
        public string AuthorId { get; set; }
    }
}
