using Microsoft.EntityFrameworkCore;
using YaelNews.Contracts;
using YaelNews.DAL;
using YaelNews.DbModel;

namespace YaelNews.Services
{
    public class DataService : IDataService
    {
        private readonly YaelNewsContext yaelNewsContext;

        public DataService(YaelNewsContext yaelNewsContext)
        {
            this.yaelNewsContext = yaelNewsContext;
        }

        public void AddNewItem(Item item) 
        {
        }

        public void AddNewSource()
        {

        }

        public void UpdateItem()
        {
        }

        public void UpdateSource()
        {

        }

        public void RemoveItem()
        {
        }

        public void RemoveSource()
        {

        }

        public async Task<List<Item>> GetItems(int pageSize, int pageIndex)
        {
            return await yaelNewsContext.Items
                .Skip(pageSize * (pageIndex - 1))
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<Item> GetItem(Guid id)
        {
            var item = await yaelNewsContext.Items.FirstOrDefaultAsync();
            return item!;
        }
    }
}