using System.Collections.Generic;
using System.Linq;
using HelloCiCd.Api.Model;

namespace HelloCiCd.Api.Services
{
    public interface IItemService
    {
        Item Get(int id);
        IList<Item> Get();
        int Add(int id, string name);
        int Delete(int id);
        Item Update(int id, string name);
    }

    public class ItemService : IItemService
    {
        private readonly IDbContext _dbContext;
        private readonly IItemFactory _itemFactory;


        public ItemService(
            IDbContext dbContext,
            IItemFactory itemFactory)
        {
            _dbContext = dbContext;
            _itemFactory = itemFactory;
        }

        public IList<Item> Get()
        {
            return _dbContext.Items;
        }

        public Item Get(int id)
        {
            return _dbContext.Items.Single(item => item.Id == id);
        }

        public int Add(int id, string name)
        {
            var newItem = _itemFactory.Create(id, name);
            _dbContext.Items.Add(newItem);

            return newItem.Id;
        }

        public int Delete(int id)
        {
            var item = _dbContext.Items.Single(i => i.Id == id);
            _dbContext.Items.Remove(item);

            return item.Id;
        }

        public Item Update(int id, string name)
        {
            var item = Get(id);
            item.Name = name;

            return item;
        }
    }
}
