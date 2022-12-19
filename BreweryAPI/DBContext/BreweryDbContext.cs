using Microsoft.EntityFrameworkCore;
using BreweryAPI.Entities;
using System.Text.Json;

namespace BreweryAPI.DBContext
{
    public class BreweryDbContext : DbContext
    {
        public BreweryDbContext(DbContextOptions<BreweryDbContext> options):base(options)
        {

        }
        public DbSet<Brewery> Breweries { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Brewery>().HasData(GetBreweriesFromJson());
            base.OnModelCreating(modelBuilder);
        }

        private Brewery[] GetBreweriesFromJson()
        {
            return JsonSerializer.Deserialize<Brewery[]>(File.ReadAllText("philyBreweries.json"));
        }
    }
}
