using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class OrderTransportDto
    {
        public int id { get; set; }

        public int transportCompanyId { get; set; }

        public string transportPrice { get; set; }

        public string weight { get; set; }

        public string name { get; set; }

    }
}