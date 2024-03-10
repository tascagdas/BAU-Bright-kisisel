﻿using Microsoft.AspNetCore.Identity;

namespace MiniShop.Entity.Concrete.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
