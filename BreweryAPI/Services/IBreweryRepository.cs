using BreweryAPI.Entities;

namespace BreweryAPI.Services
{
    public interface IBreweryRepository
    {
        Task<IEnumerable<Brewery>> GetBreweriesAsync();
        Task<Brewery?> GetBreweryAsync(string breweryId);
    }
}
