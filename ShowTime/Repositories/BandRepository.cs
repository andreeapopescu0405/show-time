using ShowTime.Context;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories
{
    public class BandRepository : RepositoryBase<Band>, IBandRepository
    {
        public BandRepository(ShowTimeContext context) : base(context) { }
    }
}
