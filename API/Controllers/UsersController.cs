using API.Data;
using API.Entitied;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUser() => await _context.Users.ToListAsync().ConfigureAwait(false);

        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> Getuser(int id)  => await _context.Users.FindAsync(id);
    }
}