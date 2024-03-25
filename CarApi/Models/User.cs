using System.ComponentModel.DataAnnotations;

namespace CarApi.Models
{
    public class User
    {
        [Key]
        [Required]
        public int IdUser { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public int FirstName { get; set; }
        
        [Required]
        public int LastName { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public ICollection<UserAddress> UserAddresses { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
