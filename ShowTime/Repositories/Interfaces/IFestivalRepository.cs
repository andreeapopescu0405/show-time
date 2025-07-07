using ShowTime.Models;

namespace ShowTime.Repositories.Interfaces
{
    public interface IFestivalRepository : IRepositoryBase<Festival>
    {
        Task<Festival?> GetFestivalWithLineupAsync(Guid id); // include FestivalBands & Band
        Task SaveLineupAsync(Guid festivalId, IEnumerable<FestivalBand> lineup);
    }
}
