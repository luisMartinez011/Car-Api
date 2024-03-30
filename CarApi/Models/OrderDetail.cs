using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarApi.Models
{
    public class OrderDetail
    {
        [Key]
        public int IdOrderDetail { get; set; }
        [Required]
        public float Total { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }


        [ForeignKey("User")]
        public Guid IdUser { get; set; }
        public User User { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }

    }
}
