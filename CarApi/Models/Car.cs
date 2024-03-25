using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarApi.Models
{
    public class Car
    {
        [Key]
        [Required]
        public int IdCar { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        [ForeignKey("Brand")]
        public int IdBrand { get; set; }
        public Brand Brand { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
