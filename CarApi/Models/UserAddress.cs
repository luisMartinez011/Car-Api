﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace CarApi.Models
{
    public class UserAddress
    {
        [Key]
        public int IdUserAddress { get; set; }
        public string? Address{ get; set; }
        public string? City { get; set; }
        public int? PostalCode { get; set; }
        public int? Telephone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;


        public Guid IdUser { get; set; }
        public User User { get; set; }


        [ForeignKey("Country")]
        public int? IdCountry { get; set; }
        public Country Country { get; set; }

    }
}
