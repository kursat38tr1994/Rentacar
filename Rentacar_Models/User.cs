using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rentacar_Models
{
    public class User : IUser
    {

   

        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        [Required]
        public string Active { get; set; }


        public ICollection<UserRole> userRole { get; set; }
    }
}
