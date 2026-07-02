using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entities
{
    public class Categories
    {
        [Key]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
