using ShowTime.Context;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories
{
    public class FestivalBandRepository: RepositoryBase<FestivalBand>, IFestivalBandRepository
    {
        public FestivalBandRepository(ShowTimeContext context) : base(context) { }
    }


}
