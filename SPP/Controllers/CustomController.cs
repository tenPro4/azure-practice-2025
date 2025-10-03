using Microsoft.AspNetCore.Mvc;
using SSP.Services;

namespace SPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomController : ControllerBase
    {
        private readonly ProductService productService;

        public CustomController(ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(productService.GetProducts());
        }
    }
}
