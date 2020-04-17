using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rentacar_Models
{
    public class Car : ICar
    {
       

        [Key]
        public int Id { get; set; }

        [Required]
        public int BrandId { get; set; }

        [ForeignKey("BrandId")]
        public Brand Type { get; set; }


        [Required]
        public string LicensePlate { get; set; }

        [Required]
        public string Fuel { get; set; }

        [Required]
        [Range(1, 10000)]
        public double CurrentPrice { get; set; }

        [Required]
        public bool Availability { get; set; }

 
    }
}
