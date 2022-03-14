﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class User
    {
        public User()
        {

        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Roles { get; set; }

        public string Permision { get; set; }

        public override string ToString()
        {
            return $"{this.Id}, {this.FirstName}";
        }
    }
}
