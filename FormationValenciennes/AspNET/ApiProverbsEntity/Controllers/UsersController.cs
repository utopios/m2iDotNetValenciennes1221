using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiProverbsEntity.Models;
using ApiProverbsEntity.Tools;
using ApiProverbsEntity.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace ApiProverbsEntity.Controllers
{
    //[Authorize("user")]
    //[Route("api/V3/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataDbContext _context;
        private ILoginService _loginService;


        public UsersController(DataDbContext context, ILoginService loginService)
        {
            _context = context;
            _loginService = loginService;
        }

        [Route("/login")]
        [HttpPost]
        public ActionResult Login([FromBody] User user)
        {
            string token = _loginService.LogIn(user.UserName, user.Password);
            if (token == null)
                return Ok(new{ error = true, message ="Aucun utilisateur avec ces paramètres"});
            else
                //return Ok(new{ error = false, UserName = user.UserName, Token = user.Token});
                return Ok(new{ error = false, user.UserName, Token = token });
        }

        [Authorize("user")]
        [Route("/testLogin")]
        [HttpPost]
        public ActionResult TestLogin()
        {
            return Ok(new { error = false });
        }

        // GET: api/Users
        [Authorize("admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/Users/5
        [Authorize("admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize("user")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [Authorize("user")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
