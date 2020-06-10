﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace USPolitics.Service.DTOs
{
    public class RegisterDTO : AccountDTO
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}
