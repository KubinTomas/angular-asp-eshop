using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class BillingAddressDto
    {
        public int id { get; set; }

        public string town { get; set; }

        public string townNumber { get; set; }

        public string townStreet { get; set; }
    }
}