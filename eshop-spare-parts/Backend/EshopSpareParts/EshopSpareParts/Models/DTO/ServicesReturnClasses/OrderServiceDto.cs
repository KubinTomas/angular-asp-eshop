using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO.ServicesReturnClasses
{
    public class OrderServiceDto
    {
        public OrderDto OrderDto { get; set; }

        public List<OrderDto> Orders { get; set; }

        public List<TransportCompanyDto> TransportCompaniesDto { get; set; }

        public int StatusCode { get; set; }

    }
}