using Microsoft.AspNetCore.Identity;

namespace ShowTime.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
