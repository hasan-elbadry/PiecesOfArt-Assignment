using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiecesOfArt_Assignment.DAL.Data;
using PiecesOfArt_Assignment.DAL.Models;

namespace PiecesOfArt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TestController(AppDbContext appDbContext) 
        {
            _context = appDbContext; 
        }

        [HttpGet]
        public IActionResult Get()
        {

            var user = new User
            {
                Id=0,
                Email = "hasan",
                Age = 20,
                Name="hasan",
                Password = "",
            };

            var ahmed = _context.Users.ToList();
            _context.SaveChanges();
            return Ok(ahmed);
        }
    }
}
