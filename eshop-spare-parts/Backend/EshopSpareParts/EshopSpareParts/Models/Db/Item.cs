using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class Item
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string Weight { get; set; }

        public string DeliveryDate { get; set; }

        public int Price { get; set; }

        public int FakeDiscount { get; set; }

        public bool Available { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime Created { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public ItemAvailability ItemAvailability { get; set; }
        public int ItemAvailabilityId { get; set; }

        public ItemState ItemState { get; set; }
        public int ItemStateId { get; set; }

    }
}