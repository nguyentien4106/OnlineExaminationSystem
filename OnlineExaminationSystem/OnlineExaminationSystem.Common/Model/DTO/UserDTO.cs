﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationSystem.Common.Model.DTO
{
    public class UserDTO
    {
        public string? Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Roles { get; set; }

        public string? Password { get; set; }

        public string? ConfirmPassword { get; set; }

        public DateTime? DOB { get; set; }

        public int? Grade { get; set; }
    }
}