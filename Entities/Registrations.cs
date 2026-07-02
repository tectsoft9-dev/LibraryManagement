using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Entities
{
    public class Registrations : IdentityUser
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
    }
}
