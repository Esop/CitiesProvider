using System;

namespace CitiesProvider.Api.Models.Cities
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
