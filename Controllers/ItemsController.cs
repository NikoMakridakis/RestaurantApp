using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public string GetItems()
        {
            return "this will be a list of products";
        }

        [HttpGet("{id}")]
        public string GetItem(int id)
        {
            return "this will be one item";
        }
    }
}