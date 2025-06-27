using System.ComponentModel.DataAnnotations;

namespace ShowTime.Models
{
    public class Booking
    {
        [Key]
        public int Guid { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public float Price { get; set; }
        public string Email { get; set; }
        public Guid FestivalId { get; set; }
        public Festival Festival { get; set; }
    }
}
