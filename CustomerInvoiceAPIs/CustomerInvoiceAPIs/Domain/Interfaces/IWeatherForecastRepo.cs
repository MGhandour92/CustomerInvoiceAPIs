using Domain.Entities;
using Domain.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IWeatherForecastRepo : IGenericRepo<WeatherForecast>
    {
        IEnumerable<WeatherForecast> GetMockData();
    }
}
