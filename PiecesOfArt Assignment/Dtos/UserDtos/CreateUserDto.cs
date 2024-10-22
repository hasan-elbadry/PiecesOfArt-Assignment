﻿using PiecesOfArt_Assignment.Models;
using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Assignment.Dtos.UserDtos
{
    public class CreateUserDto
    {
        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170), EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(250)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public byte Age { get; set; }

        [Required]
        public byte? loyaltyCardId { get; set; }
    }
}
