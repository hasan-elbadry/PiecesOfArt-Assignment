﻿using PiecesOfArt_Assignment.BBL.Dtos.CategoryDtos;
using PiecesOfArt_Assignment.BBL.Dtos.LoyaltyCardDtos;
using PiecesOfArt_Assignment.BBL.Dtos.PieceOfArtDtos;
using PiecesOfArt_Assignment.BBL.Dtos.UserDtos;
using PiecesOfArt_Assignment.DAL.Models;

namespace PiecesOfArt_Assignment.BBL.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<CreateUserDto, User>();


            CreateMap<UpdateUserDto, User>()
                .ForMember(x => x.PieceOfArts, op => op.Ignore());

            CreateMap<PieceOfArt, PieceOfArtDto>();
            CreateMap<CreatePieceOfArtDto, PieceOfArt>();
            CreateMap<UpdatePieceOfArtDto, PieceOfArt>();

            CreateMap<LoyaltyCard, LoyaltyCardDto>();
            CreateMap<CreateLoyaltyCardDto, LoyaltyCard>();
            CreateMap<UpdateLoyaltyCardDto, LoyaltyCard>();



            CreateMap<Category, CategoryDto>();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();

        }
    }
}