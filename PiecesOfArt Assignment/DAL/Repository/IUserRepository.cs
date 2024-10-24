using PiecesOfArt_Assignment.DAL.Models;

namespace PiecesOfArt_Assignment.DAL.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        public IEnumerable<PieceOfArt> isAvaliblePieceOfArts(IEnumerable<int> PieceOfArtsId);
    }
}
