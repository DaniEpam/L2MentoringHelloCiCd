using System;
using HelloCiCd.Api.Model;
using HelloCiCd.Api.Services;
using HelloCiCd.Api.Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloCiCd.Api.Test
{
    [TestClass]
    public class ItemFactory_CreateShould
    {
        private readonly Item _item;
        private readonly ItemFactory _subject;

        public ItemFactory_CreateShould()
        {
            _item = new Item
            {
                Id = 1,
                CreateDate = DateTime.Now,
                Name = "test"
            };

            _subject = new ItemFactory(new MockDateTimeService(_item.CreateDate));
        }

        [TestMethod]
        public void CreateAnItem()
        {
            var actualResult = _subject.Create(1, "test");

            Assert.AreEqual(_item.Id, actualResult.Id);
            Assert.AreEqual(_item.CreateDate, actualResult.CreateDate);
            Assert.AreEqual(_item.Name, actualResult.Name);
        }
    }
}
