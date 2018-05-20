using HelloCiCd.Api.Model;
using HelloCiCd.Api.Services;

namespace HelloCiCd.Api.Test.Mocks
{
    public class MockItemFactory : IItemFactory
    {
        private readonly Item _item;

        public MockItemFactory(Item item)
        {
            _item = item;
        }

        public Item Create(int id, string name)
        {
            return _item;
        }
    }
}
