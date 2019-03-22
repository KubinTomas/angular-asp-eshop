using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO.ServicesReturnClasses
{
    public class ItemServiceDto
    {
        public ItemDto ItemDto { get; set; }

        public CategoryDto CategoryDto { get; set; }

        public List<CategoryDto> CategoriesDto { get; set; }

        public List<ItemDto> ItemsDto { get; set; }

        public List<ItemAvailabilityDto> ItemAvailabilities { get; set; }

        public List<ItemStateDto> ItemStates { get; set; }

        public int StatusCode { get; set; }

        public int MostExpensiveItem { get; set; }

    }
}