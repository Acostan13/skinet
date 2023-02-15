using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
    public StoreContext Context { get; }
        [HttpGet]
        public string GetProducts(StoreContext context)
        {
            return "this will be a list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this will be a product";
        }
    }
}