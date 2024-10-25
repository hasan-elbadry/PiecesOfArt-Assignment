using PiecesOfArt_Assignment.DAL.Data;

namespace PiecesOfArt_Assignment.DAL.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<T> getAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? getById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public async Task<bool> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            var success = await _context.SaveChangesAsync();
            return success > 0 ? true : false;
        }
        public async Task<bool> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            var success = await _context.SaveChangesAsync();
            return success > 0 ? true : false;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null) return false;

            _context.Set<T>().Remove(entity);
            var success = await _context.SaveChangesAsync();
            return success > 0 ? true : false;
        }
    }
}
