using LibraryManagement.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<Entities.Registrations> _userManager;

        public AuthController(UserManager<Registrations> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.Select(user => new Registrations
            {
                Id = user.Id,
                UserName = user.UserName,
                StudentId = user.StudentId,
                FullName = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            }).ToListAsync();
            return View(users);
        }
    }
}
