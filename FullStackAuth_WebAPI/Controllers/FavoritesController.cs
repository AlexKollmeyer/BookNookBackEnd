using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public FavoritesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/<FavoritesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

<<<<<<< HEAD
        //// GET api/<FavoritesController>/5
        //[HttpGet("myfavorites"), Authorize]
        //public string Get(int id)
        //{
        //    try
        //    {
        //        // Retrieve the authenticated user's ID from the JWT token
        //        string userId = User.FindFirstValue("id");

        //        // Retrieve all cars that belong to the authenticated user, including the owner object
        //        var favorites = _context.Favorites.Where(c => c.UserId.Equals(userId));

        //        // Return the list of cars as a 200 OK response
        //        return StatusCode(200, favorites);
        //    }
        //    catch (Exception ex)
        //    {
        //        // If an error occurs, return a 500 internal server error with the error message
        //        return StatusCode(500, ex.Message);
        //    }
        //}
=======
        // GET api/<FavoritesController>/5
        [HttpGet("myfavorites"), Authorize]
        public string Get(int id)
        {
            try
            {
                
                string userId = User.FindFirstValue("id");

                
                var Favorites = _context.Favorites.Where(c => c.UserId.Equals(userId));

                
                return StatusCode(200, Favorites);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, ex.Message);
            }
        }
>>>>>>> b13a612a2a814294714eae2de274ad6ecacb39d6

        // POST api/<FavoritesController>
        [HttpPost]
        public IActionResult Post([FromBody] Favorite data)
        {
            try
            {
                // Retrieve the authenticated user's ID from the JWT token
                string userId = User.FindFirstValue("id");

                
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized();
                }

                
                data.UserId = userId;

                
                _context.Favorites.Add(data);
                if (!ModelState.IsValid)
                {
                    
                    return BadRequest(ModelState);
                }
                _context.SaveChanges();

                
                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<FavoritesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FavoritesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
