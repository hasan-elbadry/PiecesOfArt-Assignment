using PiecesOfArt_Assignment.DAL.Models;

namespace PiecesOfArt_Assignment.DAL.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public IEnumerable<PieceOfArt> isAvaliblePieceOfArts(IEnumerable<int> PieceOfArtsId);
    }
}
