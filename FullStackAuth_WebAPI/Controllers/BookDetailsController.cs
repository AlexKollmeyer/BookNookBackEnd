﻿using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {

                var bookDetails = new BookDetailsDTO {
                    BookId = id,
                    Reviews = _context.Reviews.Where(r => r.BookId == id).Select(r => new ReviewWithUserDto {
                        Id = r.Id,
                        BookId = r.BookId,
                        Text = r.Text,
                        Rating = r.Rating,
                        UserId = r.UserId,
                        User = new UserForDisplayDto
                        {
                            Id = r.User.Id,
                            FirstName = r.User.FirstName,
                            LastName = r.User.LastName,
                            UserName = r.User.UserName,

                        }


                    }).ToList(),
                    AverageRating=1
                    IsFavorite=false

                };
                return StatusCode(200,);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
            
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
