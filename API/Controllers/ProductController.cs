using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController :ControllerBase
    {
        [HttpGet("{id}")]

        public string Products(int id)
        {
            return "Hiii"+id;
        }
    }
}