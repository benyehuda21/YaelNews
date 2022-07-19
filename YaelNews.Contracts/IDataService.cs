using YaelNews.DbModel;

namespace YaelNews.Contracts
{
    public interface IDataService
    {
        Task<List<Item>> GetItems(int pageSize, int pageIndex);
        Task<Item> GetItem(Guid id);

        void AddNewItem(Item item);
        void AddNewSource();
        void UpdateItem();
        void UpdateSource();
        void RemoveItem();
        void RemoveSource();
    }
}
