using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class ItemImage
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public Item Item { get; set; }
        public int ItemId { get; set; }
    }
}