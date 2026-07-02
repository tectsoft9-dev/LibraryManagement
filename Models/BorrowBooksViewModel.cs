using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class BorrowBooksViewModel
    {
        [Key]
        public string BorrowId { get; set; }
        [Required]
        [ForeignKey("Members")]
        public string UserId { get; set; }
        [Required]
        [ForeignKey("Books")]
        public string BookId { get; set; }
        [Required]
        public DateTime BorrowDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
