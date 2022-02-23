using id_card_simulator.Models;
using Microsoft.EntityFrameworkCore;

namespace id_card_simulator.Database
{
    public class IndexContext : DbContext
    {
        public DbSet<ResidentModel> Residents { get; set; }

        private readonly IConfiguration _configuration;

        public IndexContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;         
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_configuration.GetConnectionString("defaultDbConfig"));
        }
    }
}
