﻿using System.ComponentModel.DataAnnotations;

namespace ExampleAspNetTodo.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
