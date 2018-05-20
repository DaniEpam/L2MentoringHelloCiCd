using HelloCiCd.Api.Model;

namespace HelloCiCd.Api.Services
{
    public interface IItemFactory
    {
        Item Create(int id, string name);
    }

    public class ItemFactory : IItemFactory
    {
        private readonly IDateTimeService _dateTimeService;

        public ItemFactory(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public Item Create(int id, string name)
        {
            var now = _dateTimeService.GetUtc();

            return new Item
            {
                CreateDate = now,
                Id = id,
                Name = name
            };
        }
    }
}
