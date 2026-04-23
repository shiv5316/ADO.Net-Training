using Microsoft.AspNetCore.Mvc;
using UserProject.DTO;
using UserProject.Models;

namespace UserProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserDbContext _context;

        public UsersController(UserDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpPost]
        public IActionResult AddUser(UserDto dto)
        {
            if (_context.Users.Any(u => u.AadharNo == dto.AadharNo))
            {
                return BadRequest("Duplicate Aadhar");
            }

            var user = new User
            {
                Password = dto.Password,
                AadharNo = dto.AadharNo
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(user);
        }
    }
}