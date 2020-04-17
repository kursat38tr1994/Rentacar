using System.Collections.Generic;

namespace Rentacar_Models
{
    public interface IUser
    {
        string Active { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string HouseNumber { get; set; }
        int Id { get; set; }
        string Password { get; set; }
        string PostalCode { get; set; }
       
        string Username { get; set; }
        public ICollection<UserRole> userRole { get; set; }
    }
}