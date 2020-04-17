using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rentacar_Models
{
    public class Brand : IBrand
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Brand Type")]
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
