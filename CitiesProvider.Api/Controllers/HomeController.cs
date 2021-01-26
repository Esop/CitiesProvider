using CitiesProvider.Api.Brokers.Storages;
using CitiesProvider.Api.Models.Cities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesProvider.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStorageBroker storageBroker;

        public HomeController(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        [HttpGet]
        public async ValueTask<IQueryable<City>> GetCity()
        {
            City city = new City()
            {
                Id = Guid.NewGuid(),
                Name = "Jacksonville",
                Latitude = 4.3,
                Longitude = 5.2,
                State = "Florida"

            };
            var storageCity = await this.storageBroker.InsertCityAsync(city);
            return Ok(storageCity);
        }
        [HttpGet("cities")]
        public ActionResult<IQueryable<City>> GetAllCities()
        {
            var data = this.storageBroker.SelectAllCities();
            return Ok(data);
        }

        
    
    }
    
}
