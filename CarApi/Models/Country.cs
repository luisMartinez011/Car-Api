using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarApi.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCountry { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(2)]
        public string CountryCode { get; set; }

        //El logo del pais se traera desde el frontend
        [Required]
        public string Flag { get; set; }



        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public ICollection<UserAddress> UserAddresses { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
