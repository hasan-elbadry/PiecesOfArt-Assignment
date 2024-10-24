namespace PiecesOfArt_Assignment.BBL.Services.Impelementation
{
    public class LoyaltyCardService : ILoyaltyCardService
    {
        private readonly IBaseRepository<LoyaltyCard> _baseRepository;
        private readonly IMapper _mapper;

        public LoyaltyCardService(IBaseRepository<LoyaltyCard> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(CreateLoyaltyCardDto LoyaltyCardDto)
        {
            var LoyaltyCard = _mapper.Map<LoyaltyCard>(LoyaltyCardDto);
            return await _baseRepository.AddAsync(LoyaltyCard);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepository.DeleteAsync(id);
        }

        public IEnumerable<LoyaltyCardDto> GetAll()
        {
            var loyaltyCards = _baseRepository.getAll();
            return _mapper.Map<IEnumerable<LoyaltyCardDto>>(loyaltyCards);
        }

        public LoyaltyCardDto getById(int id)
        {
            var loyaltyCard = _baseRepository.getById(id);
            return _mapper.Map<LoyaltyCardDto>(loyaltyCard);
        }

        public async Task<bool> Update(UpdateLoyaltyCardDto LoyaltyCardDto)
        {
            var LoyaltyCard = _mapper.Map<LoyaltyCard>(LoyaltyCardDto);
            return await _baseRepository.UpdateAsync(LoyaltyCard);
        }
    }
}
