namespace PiecesOfArt_Assignment.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();

            var usersDto = users.Select(x => new UserDto
            {
                Id = x.Id,
                Name = x.Name,
                Age = x.Age,
                Email = x.Email,
                LoyaltyCard = new LoyaltyCardDto 
                { 
                    Id = x.LoyaltyCard.Id, 
                    Name = x.LoyaltyCard.Name, 
                    Description = x.LoyaltyCard.Description 
                },
                Password = x.Password,
                PieceOfArts = x.PieceOfArts!.Select(
                    x => new PieceOfArtDto
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Price = x.Price,
                        PublicationDate = x.PublicationDate,
                        Category = new CategoryDto
                        {
                            Id = x.Category.Id,
                            Description = x.Category.Description,
                            Name = x.Category.Name
                        }
                    })
            });

            return usersDto;
        }
    }
}
