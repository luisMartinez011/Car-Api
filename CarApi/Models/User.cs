using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarApi.Models
{
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid IdUser { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required] 
        public string Password { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public Boolean IsConfirmed { get; set; } = false;

        public UserAddress UserAddress { get; set; }
        //public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
