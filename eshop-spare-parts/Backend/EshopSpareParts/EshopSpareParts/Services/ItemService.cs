using AutoMapper;
using EshopSpareParts.Models;
using EshopSpareParts.Models.CustomReturnCodes;
using EshopSpareParts.Models.Db;
using EshopSpareParts.Models.DTO;
using EshopSpareParts.Models.DTO.ServicesReturnClasses;
using EshopSpareParts.Models.Files;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EshopSpareParts.Services
{
    public class ItemService : Service
    {
        private ApplicationDbContext _context;
        private FileManager _fileManager;

        private List<int> _categoriesId;
        private List<CategoryDto> _categoriesFilteredWord;

        public ItemService(ApplicationDbContext context, FileManager fileManager)
        {
            this._context = context;
            _fileManager = fileManager;
            _categoriesId = new List<int>();
            _categoriesFilteredWord = new List<CategoryDto>();

        }

        public async Task<ItemServiceDto> CreateItemAsync(ItemDto itemDto)
        {
            var item = Mapper.Map<ItemDto, Item>(itemDto);
            item.Created = DateTime.Now;


            _context.Items.Add(item);

            await _context.SaveChangesAsync();

            itemDto.id = item.Id;

            _fileManager.CreateItemFolder(itemDto.id);

            return new ItemServiceDto { ItemDto = itemDto, StatusCode = ReturnCodes.Created };
        }
        public async Task<ItemServiceDto> EditItemAsync(ItemDto itemDto)
        {
            var item = Mapper.Map<ItemDto, Item>(itemDto);
            var itemInDb = await _context.Items.SingleOrDefaultAsync(c => c.Id == itemDto.id);
            var itemInDbImagePath = itemInDb.ImagePath;

            itemInDb = Mapper.Map(item, itemInDb);
            itemInDb.ImagePath = itemInDbImagePath;

            await _context.SaveChangesAsync();

            return new ItemServiceDto { ItemDto = itemDto, StatusCode = ReturnCodes.Ok };
        }
        public async Task<ItemServiceDto> DeleteItemAsync(int itemId)
        {
            var itemInDb = await _context.Items.SingleOrDefaultAsync(c => c.Id == itemId);
            itemInDb.IsDeleted = true;

            await _context.SaveChangesAsync();

            return new ItemServiceDto { StatusCode = ReturnCodes.Ok };
        }

        public async Task<ItemServiceDto> GetItemsAsync()
        {
            var items = await _context.Items.Where(c => !c.IsDeleted)
                                      .Include(i => i.ItemAvailability)
                                      .Include(i => i.ItemState)
                                      .ToListAsync();

            var itemsDto = new List<ItemDto>();

            foreach (var item in items)
            {
                var itemDto = Mapper.Map<Item, ItemDto>(item);
              //  itemDto.itemState = item.ItemState.Nameů


                itemsDto.Add(itemDto);
            }

            return new ItemServiceDto { ItemsDto = itemsDto, StatusCode = ReturnCodes.Ok };
        }
        private async Task<List<ItemImageDto>> GetItemImagesAsync(int itemId)
        {
            var itemImages = await _context.ItemImages.Where(c => c.ItemId == itemId).ToListAsync();

            var itemImagesDto = new List<ItemImageDto>();

            foreach (var itemImage in itemImages)
            {
                var itemImageDto = new ItemImageDto
                {
                    id = itemImage.Id,
                    imagePath = itemImage.ImagePath
                };

                itemImagesDto.Add(itemImageDto);
            }

            return itemImagesDto;
        }


        public async Task<ItemServiceDto> DeleteItemImage(int id)
        {
            var itemImage = await _context.ItemImages.SingleOrDefaultAsync(c => c.Id == id);

            _context.ItemImages.Remove(itemImage);

            await _context.SaveChangesAsync();

            return new ItemServiceDto { StatusCode = ReturnCodes.Ok };
        }
        public async Task<ItemServiceDto> GetItemAsync(int itemId)
        {
            var itemInDb = await _context.Items.Include(i => i.ItemAvailability).Include(s => s.ItemState)
                                          .SingleOrDefaultAsync(c => c.Id == itemId);


            var itemDto = Mapper.Map<Item, ItemDto>(itemInDb);

            itemDto.images = await GetItemImagesAsync(itemDto.id);

            return new ItemServiceDto { ItemDto = itemDto, StatusCode = ReturnCodes.Ok };
        }
        public async Task<ItemServiceDto> GetLastInsertedItems(int itemCount)
        {
            var items = await _context.Items.Include(c => c.ItemAvailability)
                                      .Where(c => !c.IsDeleted).OrderByDescending(c => c.Id).Take(itemCount).ToListAsync();

            var itemsDto = new List<ItemDto>();

            foreach (var item in items)
            {
                var itemDto = Mapper.Map<Item, ItemDto>(item);

                itemsDto.Add(itemDto);
            }

            return new ItemServiceDto { ItemsDto = itemsDto, StatusCode = ReturnCodes.Ok };
        }

        public async Task<ItemServiceDto> GetCategoriesAsync()
        {
            var categories = await _context.Categories.Where(c => c.ParentId == null).ToListAsync();

            var categoriesDto = new List<CategoryDto>();

            foreach (var category in categories)
            {
                _categoriesFilteredWord.Add(new CategoryDto { id = category.Id, filterWord = category.FilterWord });

                categoriesDto.Add(new CategoryDto
                {
                    id = category.Id,
                    title = category.Title,
                    filterWord = category.FilterWord,
                    parent = null,
                    parentId = category.ParentId,
                    isVisible = category.IsVisible,
                    CategoriesDto = await GetChildrenInCategoryAsync(category.Id)
                });

            }


            return new ItemServiceDto { CategoriesDto = categoriesDto, StatusCode = ReturnCodes.Ok };
        }
        public async Task<List<CategoryDto>> GetChildrenInCategoryAsync(int parentId)
        {
            var categories = await _context.Categories.Where(c => c.ParentId == parentId).OrderBy(c => c.Title).ToListAsync();

            var categoriesDto = new List<CategoryDto>();

            foreach (var category in categories)
            {
                _categoriesId.Add(category.Id);
                _categoriesFilteredWord.Add(new CategoryDto { id = category.Id, filterWord = category.FilterWord });

                categoriesDto.Add(new CategoryDto
                {
                    id = category.Id,
                    title = category.Title,
                    filterWord = category.FilterWord,
                    parent = null,
                    parentId = category.ParentId,
                    isVisible = category.IsVisible,
                    CategoriesDto = await GetChildrenInCategoryAsync(category.Id)
                });

            }

            return categoriesDto;
        }
        public async Task<List<ItemDto>> GetSearchedItemsAsync(string searchedString)
        {
            var items = await _context.Items.Where(c => !c.IsDeleted).ToListAsync();

            return new List<ItemDto>();
        }
        public async Task<ItemServiceDto> GetItemsByCategory(int categoryId)
        {
            var categoriesId = await GetAllSubCategoriesId(categoryId);

            var items = await _context.Items.Where(c => !c.IsDeleted && categoriesId.Contains(c.CategoryId)).ToListAsync();

            var itemsDto = new List<ItemDto>();

            foreach (var item in items)
            {
                var itemDto = Mapper.Map<Item, ItemDto>(item);

                itemsDto.Add(itemDto);
            }

            return new ItemServiceDto { ItemsDto = itemsDto, StatusCode = ReturnCodes.Ok };
        }
        private async Task<List<int>> GetAllSubCategoriesId(int categoryId)
        {
            _categoriesId = new List<int>();
            _categoriesId.Add(categoryId);

            var categoriesDto = await GetChildrenInCategoryAsync(categoryId);

            return _categoriesId;
        }
        public async Task<ItemServiceDto> GetItemsAvailabilities()
        {
            var itemsAvailabilities = await _context.ItemAvailabilities.ToListAsync();

            var itemsAvailabilitiesDto = new List<ItemAvailabilityDto>();

            foreach (var itemAvailability in itemsAvailabilities)
            {
                var itemAvailabilityDto = Mapper.Map<ItemAvailability, ItemAvailabilityDto>(itemAvailability);


                itemsAvailabilitiesDto.Add(itemAvailabilityDto);
            }

            return new ItemServiceDto { ItemAvailabilities = itemsAvailabilitiesDto, StatusCode = ReturnCodes.Ok };
        }
        public async Task<ItemServiceDto> GetItemsStates()
        {
            var itemsStates = await _context.ItemStates.ToListAsync();

            var itemsStatesDto = new List<ItemStateDto>();

            foreach (var itemState in itemsStates)
            {
                var itemStateDto = Mapper.Map<ItemState, ItemStateDto>(itemState);


                itemsStatesDto.Add(itemStateDto);
            }

            return new ItemServiceDto { ItemStates = itemsStatesDto, StatusCode = ReturnCodes.Ok };
        }
        public async Task<ItemServiceDto> GetMostExpensiveItem()
        {
            var maxPrice = await _context.Items.Where(i => !i.IsDeleted).MaxAsync(c => c.Price);


            return new ItemServiceDto { MostExpensiveItem = maxPrice, StatusCode = ReturnCodes.Ok };
        }
        public async Task<List<CategoryDto>> GetCategoriesFilteredWord()
        {
            var categories = await _context.Categories.Where(c => c.ParentId == null).ToListAsync();

            var categoriesDto = new List<CategoryDto>();

            foreach (var category in categories)
            {
                _categoriesFilteredWord.Add(new CategoryDto { id = category.Id, filterWord = category.FilterWord });

                await GetChildrenInCategoryAsync(category.Id);

            }

            return _categoriesFilteredWord;
        }
        

    }
}