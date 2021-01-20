using CitiesProvider.Api.Models.Cities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CitiesProvider.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<City> InsertCityAsync(City city);
        ValueTask<List<City>> GetAllCities();
    }
}
