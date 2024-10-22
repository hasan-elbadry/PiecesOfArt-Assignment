namespace PiecesOfArt_Assignment.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T? getById(byte id);
        IEnumerable<T> getAll();
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(byte id);
    }
}
