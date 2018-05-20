using System.Collections.Generic;
using HelloCiCd.Api.Model;

namespace HelloCiCd.Api.Test.Mocks
{
    public class MockDbContext : IDbContext
    {
        public MockDbContext(List<Item> items)
        {
            Items = items;
        }

        public IList<Item> Items { get; set; }
    }
}
