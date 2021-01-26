using CitiesProvider.Api.Models.Cities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public  IQueryable<City> SelectAllCities() => this.Cities;

        public async ValueTask<City> UpdateCityAsync(City city)
        {
            EntityEntry<City> aCity = this.Cities.Update(city);
            await this.SaveChangesAsync();

            return aCity.Entity; 
        }

        public async ValueTask<City> SelectCityByIdAsync(Guid id)
        {
            return await this.Cities.FindAsync(id);
        }


        
        public async ValueTask<City> DeleteCityAsync(City city)
        {
            EntityEntry<City> cityEntityEntry = this.Cities.Remove(city);
            await this.SaveChangesAsync();
            return cityEntityEntry.Entity;
        }
    }
}
