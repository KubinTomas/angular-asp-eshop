using EshopSpareParts.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class ItemDto
    {
        public int id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string imagePath { get; set; }

        public string weight { get; set; }

        public string deliveryDate { get; set; }

        public int price { get; set; }

        public int fakeDiscount { get; set; }

        public bool available { get; set; }

        public int countInCart { get; set; }

        public Category category { get; set; }

        public int categoryId { get; set; }

        public string image { get; set; }

        public ItemAvailabilityDto itemAvailability { get; set; }

        public int itemAvailabilityId { get; set; }

        public ItemStateDto itemState { get; set; }

        public int itemStateId { get; set; }

        public List<ItemImageDto> images { get; set; }

    }
}