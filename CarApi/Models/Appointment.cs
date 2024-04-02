using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarApi.Models
{
    public class Appointment
    {
        [Key]
        public int IdAppointment { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;


        [ForeignKey("User")]
        public Guid IdUser { get; set; }
        public User User { get; set; }
        [ForeignKey("Car")]
        public int IdCar { get; set; }
        public Car Car { get; set; }
    }
}
