using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        DbSet<Entities.Members> Members { get; set; }
        DbSet<Entities.Authors> Authors { get; set; }
        DbSet<Entities.Categories> Categories { get; set; }
        DbSet<Entities.Books> Books { get; set; }
        DbSet<Entities.BorrowBooks> BorrowBooks { get; set; }
        DbSet<Entities.Registrations> Registrations { get; set; }
    }
}
