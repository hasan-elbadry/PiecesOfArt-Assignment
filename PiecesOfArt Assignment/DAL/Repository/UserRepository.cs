using PiecesOfArt_Assignment.DAL.Data;
using PiecesOfArt_Assignment.DAL.Models;
using System.Data.SqlTypes;

namespace PiecesOfArt_Assignment.DAL.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        } 

        public override IEnumerable<User> getAll()
        {
            return _context.Users
            .Include(x => x.LoyaltyCard)
            .Include(x => x.PieceOfArts!)
            .ThenInclude(x => x.Category)
            .ToList();
        }

        public IEnumerable<PieceOfArt> isAvaliblePieceOfArts(IEnumerable<int> PieceOfArtsId)
        {
            return _context.PieceOfArts.Where(x => PieceOfArtsId.Contains(x.Id)).ToList();
        }
    }
}
