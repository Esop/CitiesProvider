using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CitiesProvider.Api.Brokers.Storages
{
    public partial class StorageBroker : DbContext, IStorageBroker
    {
        private IConfiguration configuration;
        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databseConnectionString = this.configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(databseConnectionString);
        }
    }
}
