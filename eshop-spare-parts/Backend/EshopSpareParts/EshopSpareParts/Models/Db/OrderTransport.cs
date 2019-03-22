using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class OrderTransport
    {
        public int Id { get; set; }

        public TransportCompany TransportCompany { get; set; }
        public int TransportCompanyId { get; set; }

        public int TransportPrice { get; set; }

        public string Weight { get; set; }
    }
}