namespace PiecesOfArt_Assignment.BBL.Services.Impelementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> _baseRepository;
        private readonly IMapper _mapper;

        public CategoryService(IBaseRepository<Category> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(CreateCategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            return await _baseRepository.AddAsync(category);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepository.DeleteAsync(id);
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            var categories = _baseRepository.getAll();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }

        public CategoryDto getById(int id)
        {
            var user = _baseRepository.getById(id);
            return _mapper.Map<CategoryDto>(user);
        }

        public async Task<bool> Update(UpdateCategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            return await _baseRepository.UpdateAsync(category);
        }
    }
}
