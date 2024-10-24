namespace PiecesOfArt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = _categoryService.getById(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryDto dto)
        {
            bool sucess = await _categoryService.Update(dto);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool sucess = await _categoryService.DeleteAsync(id);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            bool success = await _categoryService.AddAsync(dto);

            if (!success)
                return NotFound();

            return Ok();
        }

    }
}
