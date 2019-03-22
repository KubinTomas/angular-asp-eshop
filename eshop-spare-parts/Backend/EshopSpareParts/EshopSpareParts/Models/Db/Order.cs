using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class Order
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Finished { get; set; }

        public Status Status { get; set; }
        public int StatusId { get; set; }

        public CompleteOrderSummary CompleteOrderSummary { get; set; }
        public int CompleteOrderSummaryId { get; set; }

    }
}