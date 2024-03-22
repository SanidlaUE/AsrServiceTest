using AsrServiceTest.Register;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AsrServiceTest.DAL
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base(GetOptionsFromConfig())
        {
           // Database.EnsureDeleted();
           // Database.EnsureCreated();
        }
        public DbSet<OrderLine> OrderLines { get; set; }
        private static DbContextOptions<AppDbContext> GetOptionsFromConfig()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return optionsBuilder.Options;
        }
    }
}
