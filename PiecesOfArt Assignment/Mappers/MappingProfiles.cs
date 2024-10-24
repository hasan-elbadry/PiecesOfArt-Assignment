using AutoMapper;

namespace PiecesOfArt_Assignment.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>();
            CreateMap<PieceOfArt, PieceOfArtDto>();
            CreateMap<LoyaltyCard, LoyaltyCardDto>();
            CreateMap<Category, CategoryDto>();
        }
    }
}