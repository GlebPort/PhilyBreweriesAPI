using BreweryAPI.DBContext;
using BreweryAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BreweryAPI.Services
{
    public class BreweryRepository : IBreweryRepository
    {
        private readonly BreweryDbContext _context;

        public BreweryRepository(BreweryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Brewery>> GetBreweriesAsync()
        {
            return await  _context.Breweries.OrderBy(b => b.name).ToListAsync();
        }

        public async Task<Brewery?> GetBreweryAsync(string breweryId)
        {
            return await _context.Breweries
                  .Where(b => b.id == breweryId).FirstOrDefaultAsync();
        }

    }
}
