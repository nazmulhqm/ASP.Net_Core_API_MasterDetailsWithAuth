﻿using System.ComponentModel.DataAnnotations;

namespace MasterDetailsWithAuthenticationInCoreAPI.DTOs
{
    public class UserLoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
