﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarApi.Models
{
    public class Brand
    {
        [Key]
        [Required]
        public int IdBrand { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Country")]
        public int IdCountry { get; set; }
        public Country Country { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public ICollection<Car> Cars { get; set; }

    }
}