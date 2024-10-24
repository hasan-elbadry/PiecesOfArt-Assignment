namespace PiecesOfArt_Assignment.DAL.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T? getById(int id);
        IEnumerable<T> getAll();
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
