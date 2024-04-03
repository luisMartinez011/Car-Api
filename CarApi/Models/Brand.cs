using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
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
        public string Logo { get; set; }

        [ForeignKey("Country")]
        public int IdCountry { get; set; }
        [JsonIgnore]
        public Country Country { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }


        public ICollection<Car> Cars { get; set; }

    }
}
