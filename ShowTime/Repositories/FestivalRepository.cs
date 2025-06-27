using ShowTime.Context;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories
{
    public class FestivalRepository : RepositoryBase<Festival>, IFestivalRepository
    {
        public FestivalRepository(ShowTimeContext context) : base(context) { }
    }
    {
    }
}
