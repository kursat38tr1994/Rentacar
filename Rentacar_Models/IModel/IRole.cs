using System.Collections.Generic;

namespace Rentacar_Models
{
    public interface IRole
    {
        string Description { get; set; }
        int Id { get; set; }
        public ICollection<UserRole> userRole { get; set; }
    }
}