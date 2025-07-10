using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories
{
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(ShowTimeContext context) : base(context) { }
        public async Task<IEnumerable<Booking>> GetAllByUserIdAsync(string userId)
        {
            if (!Guid.TryParse(userId, out var guid))
                return Enumerable.Empty<Booking>();

            return await _context.Bookings
                .Where(b => b.UserId == guid)
                .Include(b => b.Festival)
                .ToListAsync();
        }
        public async Task<Booking?> GetByIdWithFestivalAsync(Guid id)
        {
            return await _context.Bookings
                .Include(b => b.Festival)
                .FirstOrDefaultAsync(b => b.Id == id);
        }



    }



}
