using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiecesOfArt_Assignment.Data;
using PiecesOfArt_Assignment.Dtos.UserDtos;
using PiecesOfArt_Assignment.Models;
using PiecesOfArt_Assignment.Repository;

namespace PiecesOfArt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IBaseRepository<User> _userRepository;

        private readonly IUserRepository _user;
        public TestController(IBaseRepository<User> userRepository, IUserRepository user)
        {
            _userRepository = userRepository;
            _user = user;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var entity = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Age = dto.Age,
                Password = dto.Password,
                loyaltyCardId = dto.loyaltyCardId,
            };

            bool success = await _userRepository.AddAsync(entity);

            if (!success)
                return NotFound();

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            
            return Ok(_user.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(byte id)
        {
            var user = _userRepository.getById(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserDto dto)
        {
            var user = new User 
            {
                Id = dto.Id,
                Name = dto.Name,
                Age= dto.Age,
                Email = dto.Email,
                loyaltyCardId= dto.loyaltyCardId,
                PieceOfArts = dto.PieceOfArts.Select(x=> new PieceOfArt { Id = (byte)x }),
                Password = dto.Password,
            };
            bool sucess = await _userRepository.UpdateAsync(user);

            if (!sucess) 
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(byte id)
        {
            bool sucess = await _userRepository.DeleteAsync(id);

            if (!sucess)
                return BadRequest();

            return Ok();
        }
    }
}
