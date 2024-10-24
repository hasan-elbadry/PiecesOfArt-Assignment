﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PiecesOfArt_Assignment.BBL.Dtos.UserDtos;
using PiecesOfArt_Assignment.BBL.Services.Interfaces;
using PiecesOfArt_Assignment.DAL.Repository;

namespace PiecesOfArt_Assignment.BBL.Services.Impelementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBaseRepository<User> _baseRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper, IBaseRepository<User> baseRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _baseRepository = baseRepository;
        }

        public async Task<bool> AddAsync(CreateUserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            return await _baseRepository.AddAsync(user);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepository.DeleteAsync(id);
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return usersDto;
        }

        public UserDto getById(int id)
        {
            var user = _baseRepository.getById(id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<bool> Update(UpdateUserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var pieceOfArts = _userRepository.isAvaliblePieceOfArts(userDto.PieceOfArts!);
            user.PieceOfArts = pieceOfArts;

            return await _baseRepository.UpdateAsync(user);
        }
    }
}


//var usersDto = users.Select(x => new UserDto
//{
//    Id = x.Id,
//    Name = x.Name,
//    Age = x.Age,
//    Email = x.Email,
//    LoyaltyCard = new LoyaltyCardDto 
//    { 
//        Id = x.LoyaltyCard.Id, 
//        Name = x.LoyaltyCard.Name, 
//        Description = x.LoyaltyCard.Description 
//    },
//    Password = x.Password,
//    PieceOfArts = x.PieceOfArts!.Select(
//        x => new PieceOfArtDto
//        {
//            Id = x.Id,
//            Title = x.Title,
//            Price = x.Price,
//            PublicationDate = x.PublicationDate,
//            Category = new CategoryDto
//            {
//                Id = x.Category.Id,
//                Description = x.Category.Description,
//                Name = x.Category.Name
//            }
//        })
//});