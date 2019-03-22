using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class CompleteOrderSummaryDto
    {
        public int id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string deliveryTown { get; set; }

        public string deliveryTownNumber { get; set; }

        public string deliveryTownStreet { get; set; }

        public string invoiceTown { get; set; }

        public string invoiceTownNumber { get; set; }

        public string invoiceTownStreet { get; set; }

        public int totalPrice { get; set; }

    }
}