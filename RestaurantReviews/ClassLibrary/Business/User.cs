using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace ClassLibrary.Business
{
    public class User
    {
        public User()
        {

        }
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

      
        public string FirstName { get; set; }
       
        public string LastName { get; set; }

        public Role Roles { get; set; }

       

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
