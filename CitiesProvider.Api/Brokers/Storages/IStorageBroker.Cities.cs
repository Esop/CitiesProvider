using CitiesProvider.Api.Models.Cities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesProvider.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<City> InsertCityAsync(City city);
        IQueryable<City> SelectAllCities();

        ValueTask<City> SelectCityByIdAsync(Guid id);

        ValueTask<City> UpdateCityAsync(City city);
        ValueTask<City> DeleteCityAsync(City city);
    }
}
