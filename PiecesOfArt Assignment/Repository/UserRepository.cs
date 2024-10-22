using Microsoft.EntityFrameworkCore;
using PiecesOfArt_Assignment.Data;
using PiecesOfArt_Assignment.Models;

namespace PiecesOfArt_Assignment.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users
                .Include(x => x.PieceOfArts)
                    .ThenInclude(pa => pa.Category)
                .Include(x => x.LoyaltyCard)
                .ToList();
        }
    }
}
