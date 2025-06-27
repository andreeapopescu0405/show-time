using ShowTime.Emuns;
using System.ComponentModel.DataAnnotations;

namespace ShowTime.Models
{
    public class Band
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Festival> Festivals { get; set; }
    }
}
