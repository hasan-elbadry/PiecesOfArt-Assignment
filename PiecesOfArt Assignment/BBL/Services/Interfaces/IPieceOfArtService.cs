namespace PiecesOfArt_Assignment.BBL.Services.Interfaces
{
    public interface IPieceOfArtService
    {
        public IEnumerable<PieceOfArtDto> GetAll();
        public Task<bool> Update(UpdatePieceOfArtDto pieceOfArtDto);
        PieceOfArtDto getById(int id);
        Task<bool> DeleteAsync(int id);
        Task<bool> AddAsync(CreatePieceOfArtDto pieceOfArtDto);
    }
}
