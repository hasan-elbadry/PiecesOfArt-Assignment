using PiecesOfArt_Assignment.Models;

namespace PiecesOfArt_Assignment.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll(); 
    }
}
