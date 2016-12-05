﻿using System.ComponentModel.DataAnnotations;

namespace PollHub.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}