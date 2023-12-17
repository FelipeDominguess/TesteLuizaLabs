using Microsoft.EntityFrameworkCore;
using TesteLuizaLabs.Data.DataModels;

namespace TesteLuizaLabs.Data
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<CustomerModel> Customers { get; set; }
    }
}
