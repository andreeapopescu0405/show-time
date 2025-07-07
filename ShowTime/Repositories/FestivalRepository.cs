using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories
{
    public class FestivalRepository : RepositoryBase<Festival>, IFestivalRepository
    {
        public FestivalRepository(ShowTimeContext context) : base(context) { }

        public async Task<Festival?> GetFestivalWithLineupAsync(Guid id)
        {
            return await _context.Festivals
                .Include(f => f.FestivalsBands)
                    .ThenInclude(fb => fb.Band)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task SaveLineupAsync(Guid festivalId, IEnumerable<FestivalBand> lineup)
        {
            var current = _context.FestivalsBands.Where(fb => fb.FestivalId == festivalId);
            _context.FestivalsBands.RemoveRange(current);
            await _context.FestivalsBands.AddRangeAsync(lineup);
            await _context.SaveChangesAsync();
        }

    }

}
