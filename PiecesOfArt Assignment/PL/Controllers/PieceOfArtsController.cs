namespace PiecesOfArt_Assignment.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PieceOfArtsController : ControllerBase
    {
        private readonly IPieceOfArtService _pieceOfArtService;

        public PieceOfArtsController(IPieceOfArtService pieceOfArtService)
        {
            _pieceOfArtService = pieceOfArtService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_pieceOfArtService.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = _pieceOfArtService.getById(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdatePieceOfArtDto dto)
        {
            bool sucess = await _pieceOfArtService.Update(dto);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool sucess = await _pieceOfArtService.DeleteAsync(id);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePieceOfArtDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            bool success = await _pieceOfArtService.AddAsync(dto);

            if (!success)
                return NotFound();

            return Ok();
        }

    }
}
