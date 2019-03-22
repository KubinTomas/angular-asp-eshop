using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class BillingAddress
    {
        public int Id { get; set; }

        public string Town { get; set; }

        public string TownNumber { get; set; }

        public string TownStreet { get; set; }
    }
}