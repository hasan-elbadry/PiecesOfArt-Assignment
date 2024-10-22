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
                .Include(x=>x.LoyaltyCard)
                .Include(x=>x.PieceOfArts!)
                .ThenInclude(x=>x.Category)
                .ToList();
        }
    }
}
