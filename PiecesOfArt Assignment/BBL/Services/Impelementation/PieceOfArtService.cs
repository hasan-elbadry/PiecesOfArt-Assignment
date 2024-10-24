namespace PiecesOfArt_Assignment.BBL.Services.Impelementation
{
    public class PieceOfArtService : IPieceOfArtService
    {
        private readonly IBaseRepository<PieceOfArt> _baseRepository;
        private readonly IMapper _mapper;

        public PieceOfArtService(IBaseRepository<PieceOfArt> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(CreatePieceOfArtDto PieceOfArtDto)
        {
            var PieceOfArt = _mapper.Map<PieceOfArt>(PieceOfArtDto);
            return await _baseRepository.AddAsync(PieceOfArt);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepository.DeleteAsync(id);
        }

        public IEnumerable<PieceOfArtDto> GetAll()
        {
            var pieceOfArts = _baseRepository.getAll();
            return _mapper.Map<IEnumerable<PieceOfArtDto>>(pieceOfArts);
        }

        public PieceOfArtDto getById(int id)
        {
            var pieceOfArt = _baseRepository.getById(id);
            return _mapper.Map<PieceOfArtDto>(pieceOfArt);
        }

        public async Task<bool> Update(UpdatePieceOfArtDto PieceOfArtDto)
        {
            var PieceOfArt = _mapper.Map<PieceOfArt>(PieceOfArtDto);
            return await _baseRepository.UpdateAsync(PieceOfArt);
        }
    }
}
