using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShowTime.Models
{
    public class Festival
    {
        [Key]
        public Guid Id { get; set; }  
        [Required]
        public string Name { get; set; }
        [Required]
        public String Location { get; set; }
        [Required]
        public DateTime DataStart { get; set; }
        [Required]
        public DateTime DataEnd { get; set; }
        public ICollection<FestivalBand> FestivalsBands { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public string? ImageUrl { get; set; }


    }
}
