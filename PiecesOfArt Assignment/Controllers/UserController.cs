namespace PiecesOfArt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBaseRepository<User> _userRepository;

        private readonly IUserService _user;
        public UserController(IBaseRepository<User> userRepository, IUserService user)
        {
            _userRepository = userRepository;
            _user = user;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_user.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
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
                Age = dto.Age,
                Email = dto.Email,
                loyaltyCardId = dto.loyaltyCardId,
                PieceOfArts = dto.PieceOfArts!.Select(x => new PieceOfArt { Id = (int)x }),
                Password = dto.Password,
            };   
            bool sucess = await _userRepository.UpdateAsync(user);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool sucess = await _userRepository.DeleteAsync(id);

            if (!sucess)
                return BadRequest();

            return Ok();
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


    }
}
