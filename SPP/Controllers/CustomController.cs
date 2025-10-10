using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SPP.API.Configurations;
using SSP.Services;

namespace SPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomController : ControllerBase
    {
        private readonly CustomSettings _settings;

        public CustomController(
            IOptions<CustomSettings> settings
            )
        {
            _settings = settings.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new ProductService().GetProducts());
        }

        [HttpGet, Route("[action]")]
        public IActionResult Settings()
        {
            return Ok(_settings);
        }
    }
}
