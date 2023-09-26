﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.Capstone.FlamingoDAL.Models
{
    public class Register
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AadharId { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return "[" + CustomerId + ", " + FirstName + ", " + LastName + ", " + Email + ", " + DateOfBirth + ", " + AadharId + ", " + Password + "]";
        }
    }
}
