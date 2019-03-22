using EshopSpareParts.Models.Authorize;
using EshopSpareParts.Models.DTO;
using EshopSpareParts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EshopSpareParts.Controllers.Api.Eshop
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    public class ItemController : ApiController
    {
        private ItemService _service;

        public ItemController(ItemService service)
        {
            _service = service;
        }
        //[AdminAuthorize]
        [HttpPost, Route("api/create/item")]
        public async Task<IHttpActionResult> CreateItem(ItemDto itemDto)
        {
            var accountServiceDto = await _service.CreateItemAsync(itemDto);

            return Created(new Uri(Request.RequestUri + accountServiceDto.ItemDto.id.ToString()), accountServiceDto);
        }
        [HttpPut, Route("api/edit/item")]
        public async Task<IHttpActionResult> EditItem(ItemDto itemDto)
        {
            var accountServiceDto = await _service.EditItemAsync(itemDto);

            return Ok(accountServiceDto);
        }
        [HttpDelete, Route("api/delete/item/{itemId}")]
        public async Task<IHttpActionResult> DeleteItem(int itemId)
        {
            var accountServiceDto = await _service.DeleteItemAsync(itemId);

            return Ok(accountServiceDto);
        }
        [HttpDelete, Route("api/delete/item/image/{imageId}")]
        public async Task<IHttpActionResult> DeleteItemImage(int imageId)
        {
            var accountServiceDto = await _service.DeleteItemImage(imageId);

            return Ok(accountServiceDto);
        }
        
        [HttpGet, Route("api/get/items")]
        public async Task<IHttpActionResult> GetItems()
        {
            var accountServiceDto = await _service.GetItemsAsync();

            return Ok(accountServiceDto);
        }

        [HttpGet, Route("api/get/last/inserted/items/{itemCount}")]
        public async Task<IHttpActionResult> GetLastInsertedItems(int itemCount)
        {
            var accountServiceDto = await _service.GetLastInsertedItems(itemCount);

            return Ok(accountServiceDto);
        }

        [HttpGet, Route("api/get/filtered/items/{filterString}")]
        public async Task<IHttpActionResult> GetFilteredItems(string filterString)
        {
            var accountServiceDto = await _service.GetSearchedItemsAsync(filterString);

            return Ok(accountServiceDto);
        }

        [HttpGet, Route("api/get/items/category/{categoryId}")]
        public async Task<IHttpActionResult> GetItemsByCategory(int categoryId)
        {
            var accountServiceDto = await _service.GetItemsByCategory(categoryId);

            return Ok(accountServiceDto);
        }

        [HttpGet, Route("api/get/item/{itemId}")]
        public async Task<IHttpActionResult> GetItem(int itemId)
        {
            var accountServiceDto = await _service.GetItemAsync(itemId);

            return Ok(accountServiceDto);
        }


        [HttpGet, Route("api/get/categories")]
        public async Task<IHttpActionResult> GetCategories()
        {
            var categoriesDto = await _service.GetCategoriesAsync();

            return Ok(categoriesDto);
        }

        [HttpGet, Route("api/get/item/availabilities")]
        public async Task<IHttpActionResult> GetItemsAvailabilities()
        {
            var availabilities = await _service.GetItemsAvailabilities();

            return Ok(availabilities);
        }
        [HttpGet, Route("api/get/item/states")]
        public async Task<IHttpActionResult> GetItemsStates()
        {
            var states = await _service.GetItemsStates();

            return Ok(states);
        }
        [HttpGet, Route("api/get/most/expensive/item")]
        public async Task<IHttpActionResult> GetMostExpensiveItem()
        {
            var itemServiceDto = await _service.GetMostExpensiveItem();

            return Ok(itemServiceDto.MostExpensiveItem);
        }
        [HttpGet, Route("api/get/category/filtered/words")]
        public async Task<IHttpActionResult> GetFilteredWords()
        {
            var categoryWithFilteredWords = await _service.GetCategoriesFilteredWord();

            return Ok(categoryWithFilteredWords);
        }
        
    }
}
