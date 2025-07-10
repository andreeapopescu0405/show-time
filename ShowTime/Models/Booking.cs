using System.ComponentModel.DataAnnotations;

namespace ShowTime.Models
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; } 
        public DateTime Date { get; set; }
        public float Price { get; set; }
        public string Email { get; set; }
        public Guid FestivalId { get; set; }
        public Festival Festival { get; set; }
        public Guid UserId { get; set; }    
        public ApplicationUser User { get; set; } 
    }
}
