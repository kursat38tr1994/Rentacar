using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rentacar_Models
{
    public class Role : IRole
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<UserRole> userRole { get; set; }
    }
}
