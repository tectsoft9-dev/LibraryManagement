using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class MembersViewModel
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
