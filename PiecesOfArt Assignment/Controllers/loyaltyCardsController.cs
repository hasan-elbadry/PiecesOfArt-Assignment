using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiecesOfArt_Assignment.BBL.Services.Interfaces;

namespace PiecesOfArt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loyaltyCardsController : ControllerBase
    {
        private readonly ILoyaltyCardService _LoyaltyCardService;

        public loyaltyCardsController(ILoyaltyCardService loyaltyCardService)
        {
            _LoyaltyCardService = loyaltyCardService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_LoyaltyCardService.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var loyaltyCard  = _LoyaltyCardService.getById(id);
            if (loyaltyCard  == null)
                return NotFound();

            return Ok(loyaltyCard );
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateLoyaltyCardDto dto)
        {
            bool sucess = await _LoyaltyCardService.Update(dto);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool sucess = await _LoyaltyCardService.DeleteAsync(id);

            if (!sucess)
                return BadRequest();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLoyaltyCardDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            bool success = await _LoyaltyCardService.AddAsync(dto);

            if (!success)
                return NotFound();

            return Ok();
        }

    }
}
