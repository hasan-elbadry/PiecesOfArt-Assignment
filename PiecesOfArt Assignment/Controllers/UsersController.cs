using PiecesOfArt_Assignment.BBL.Dtos.UserDtos;
using PiecesOfArt_Assignment.BBL.Services.Interfaces;
using PiecesOfArt_Assignment.DAL.Models;
using PiecesOfArt_Assignment.DAL.Repository;

namespace PiecesOfArt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService user)
        {
            _userService = user;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.getById(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserDto dto)
        {
            bool sucess = await _userService.Update(dto);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool sucess = await _userService.DeleteAsync(id);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            bool success = await _userService.AddAsync(dto);

            if (!success)
                return NotFound();

            return Ok();
        }


    }
}
