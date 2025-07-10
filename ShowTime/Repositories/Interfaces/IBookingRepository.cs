using ShowTime.Models;

namespace ShowTime.Repositories.Interfaces
{
    public interface IBookingRepository : IRepositoryBase<Booking>
    {
        Task<IEnumerable<Booking>> GetAllByUserIdAsync(string userId);
        Task<Booking?> GetByIdWithFestivalAsync(Guid id);


    }
}
