using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace CarApi.Models
{
    public class UserAddress
    {
        [Key]
        public int IdUserAddress { get; set; }
        [Required]
        public string AddressKey { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public int Telephone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        [ForeignKey("User")]
        public int IdUser { get; set; }
        public User User { get; set; }


        [ForeignKey("Country")]
        public int IdCountry { get; set; }
        public Country Country { get; set; }

    }
}
