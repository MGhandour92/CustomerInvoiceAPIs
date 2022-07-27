using Domain.Entities;
using Domain.Main;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IUnitOfWork unitOfWork, ILogger<WeatherForecastController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        // GET: api/<ShipperController>
        [HttpGet, Authorize]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            return Ok(_unitOfWork.WeatherForecasts.GetMockData());
        }
    }
}