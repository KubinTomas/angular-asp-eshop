using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class CompleteOrderSummary
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string DeliveryTown { get; set; }

        public string DeliveryTownNumber { get; set; }

        public string DeliveryTownStreet { get; set; }

        public string InvoiceTown { get; set; }

        public string InvoiceTownNumber { get; set; }

        public string InvoiceTownStreet { get; set; }

        public int TotalPrice { get; set; }

        public OrderTransport OrderTransport { get; set; }
        public int OrderTransportId { get; set; }

        public User User { get; set; }
        public int? UserId { get; set; }
    }
}