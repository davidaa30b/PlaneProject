﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaneProject.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public  string Phonenumber { get; set; }

        public string EGN { get; set; }

        public string Address { get; set; }

        public string Role { get; set; }

    }
}