namespace PiecesOfArt_Assignment.BBL.Services.Interfaces
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryDto> GetAll();
        public Task<bool> Update(UpdateCategoryDto userDto);
        CategoryDto getById(int id);
        Task<bool> DeleteAsync(int id);
        Task<bool> AddAsync(CreateCategoryDto userDto);
    }
}
