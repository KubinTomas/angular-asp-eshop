using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class OrderDifferentDataAndAddressDto
    {
        public int id { get; set; }

        public int name { get; set; }

        public int surname { get; set; }

        public int email { get; set; }

        public int phone { get; set; }

        public string town { get; set; }

        public string townNumber { get; set; }

        public string townStreet { get; set; }
    }
}