using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class ItemAvailability
    {
        public int Id { get; set; }

        public string Title { get; set; }

        const int InStock = 2;
        const int SoldOut = 3;
        const int OnRequest = 4;

    }
}