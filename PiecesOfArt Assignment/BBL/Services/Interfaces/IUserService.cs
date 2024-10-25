namespace PiecesOfArt_Assignment.BBL.Services.Interfaces
{
    public interface IUserService
    {
        public IEnumerable<UserDto> GetAll();
        public Task<bool> Update(UpdateUserDto userDto);
        UserDto getById(int id);
        Task<bool> DeleteAsync(int id);
        Task<bool> AddAsync(CreateUserDto userDto);
    }
}
