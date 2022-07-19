using Microsoft.AspNetCore.Mvc;
using YaelMews.Model;
using YaelNews.Contracts;

namespace YaelNews.Controllers
{
    // https://www.yaelnews.com/api/items
    // rest api
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private IDataService _dataService;

        public ItemController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public async Task<List<Item>> Get(int pageSize, int pageIndex)
        {
            var items = await _dataService.GetItems(pageSize, pageIndex);
            return Ok(new List<Item>());
        }

        [HttpPut]
        public async Task Update(Item item)
        {

        }

        [HttpPost]
        public async Task AddNewItem(Item item)
        {

        }
    }
}
