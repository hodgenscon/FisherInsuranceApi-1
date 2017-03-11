using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;

namespace FisherInsuranceApi.Data
{
    public class FisherContext : DbContext
    {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "User ID=fisher;Password=fisher;Host=localhost;Port=5432;Database=fisher-insurance;Pooling=false;";
            
            optionsBuilder.UseNpgsql(connection);
        }
    }
}