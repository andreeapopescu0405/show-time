using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShowTime.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String Username { get; set; }
        public ICollection<Festival> Festivals { get; set; }
    }
}
