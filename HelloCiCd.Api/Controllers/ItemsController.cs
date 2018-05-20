using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloCiCd.Api.Model;
using HelloCiCd.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloCiCd.Api.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            var q = 12;

            _itemService = itemService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            var models = _itemService.Get();

            return models;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            var model = _itemService.Get(id);

            return model;
        }

        // POST api/values/5
        [HttpPost("{id}")]
        public void Post(int id, [FromBody]string name)
        {
            var model = _itemService.Update(id, name);
        }

        // PUT api/values/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string name)
        {
            _itemService.Add(id, name);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var model = _itemService.Delete(id);
        }
    }
}
