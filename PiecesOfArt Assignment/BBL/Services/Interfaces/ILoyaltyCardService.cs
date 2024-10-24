namespace PiecesOfArt_Assignment.BBL.Services.Interfaces
{
    public interface ILoyaltyCardService
    {
        public IEnumerable<LoyaltyCardDto> GetAll();
        public Task<bool> Update(UpdateLoyaltyCardDto userDto);
        LoyaltyCardDto getById(int id);
        Task<bool> DeleteAsync(int id);
        Task<bool> AddAsync(CreateLoyaltyCardDto userDto);
    }
}
