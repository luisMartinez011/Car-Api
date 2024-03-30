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
        public DateTime Created_at { get; set; }
        [Required]
        public DateTime Modified_at { get; set; }


        [ForeignKey("User")]
        public Guid IdUser { get; set; }
        public User User { get; set; }
        [ForeignKey("Car")]
        public int Id_Car { get; set; }
        public Car Car { get; set; }
    }
}
