using CitiesProvider.Api.Models.Cities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CitiesProvider.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<City> Cities { get; set; }
        public async ValueTask<City> InsertCityAsync(City city)
        {
            EntityEntry<City> cityEntityEntry = await this.Cities.AddAsync(city);
            await this.SaveChangesAsync();

            return cityEntityEntry.Entity;
        }

        public async ValueTask<List<City>> GetAllCities()
        {
            var cities = new List<City>()
            {
               new City() {State = "Florida", Name = "Jacksonville", Longitude = 3.0, Latitude =  9.3, Id = Guid.NewGuid() },
               new City() {State = "Georgia", Name = "Atlanta", Longitude = 2.0, Latitude =  8.3, Id = Guid.NewGuid() },

            };
            return cities;


        }
    }
}
