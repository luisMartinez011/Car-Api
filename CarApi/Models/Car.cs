using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CarApi.Models
{
    public class Car
    {
        [Key]
        public int IdCar { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Model { get; set; }
        [Required]
        public float Year { get; set; }
        [Required]
        public float Price { get; set; }
        //[Required]
        //public string Description { get; set; }
        [Required]
        public string Image { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("Brand")]
        public int IdBrand { get; set; }
        [JsonIgnore]
        public Brand Brand { get; set; }

        //public ICollection<OrderItem> OrderItem { get; set; }
        [JsonIgnore]
        protected ICollection<Appointment> Appointments { get; set; }
    }
}
