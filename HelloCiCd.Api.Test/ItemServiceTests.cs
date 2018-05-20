using System;
using System.Collections.Generic;
using HelloCiCd.Api.Model;
using HelloCiCd.Api.Services;
using HelloCiCd.Api.Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloCiCd.Api.Test
{
    [TestClass]
    public class ItemService_GetShould
    {
        private readonly Item _item;
        private readonly ItemService _subject;

        public ItemService_GetShould()
        {
            _item = new Item {Id = 1, CreateDate = DateTime.MinValue, Name = "test1"};

            _subject = new ItemService(new MockDbContext(new List<Item>(new[] {_item})), new MockItemFactory(_item));
        }

        [TestMethod]
        public void ReturnAllAnItem()
        {
            var actualResult = _subject.Get(1);

            Assert.AreEqual(_item.Id, actualResult.Id);
            Assert.AreEqual(_item.CreateDate, actualResult.CreateDate);
            Assert.AreEqual(_item.Name, actualResult.Name);
        }

        [TestMethod]
        public void ThrowExcpetionsIfItemIsMissing()
        {
            Assert.ThrowsException<InvalidOperationException>(() => _subject.Get(0));
        }
    }
}
