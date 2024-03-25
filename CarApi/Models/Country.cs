using System.ComponentModel.DataAnnotations;

namespace CarApi.Models
{
    public class Country
    {
        [Key]
        [Required]
        public int IdCountry { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Logo { get; set; }



        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public ICollection<UserAddress> UserAddresses { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
