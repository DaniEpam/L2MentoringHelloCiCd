using System;
using System.Collections.Generic;

namespace HelloCiCd.Api.Model
{
    public interface IDbContext
    {
        IList<Item> Items { get; set; }
    }

    public class InMemoryDbContext : IDbContext
    {
        private static IList<Item> _inMemoryItems = new List<Item>
        {
            new Item { Id = 1, Name = "Item#1", CreateDate = DateTime.Now },
            new Item { Id = 2, Name = "Item#2", CreateDate = DateTime.Now },
            new Item { Id = 3, Name = "Item#3", CreateDate = DateTime.Now },
        };

        public IList<Item> Items
        {
            get => _inMemoryItems;
            set => _inMemoryItems = value;
        }
    }
}
