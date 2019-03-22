using EshopSpareParts.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class OrderDto
    {
        public int id { get; set; }

        public string code { get; set; }

        public DateTime created { get; set; }

        public DateTime? finished { get; set; }

        public StatusDto status { get; set; }

        public List<ItemDto> items { get; set; }

        public CompleteOrderSummaryDto orderSummary { get; set; }

        public OrderTransportDto orderTransport { get; set; }

        public User user { get; set; }

    }
}