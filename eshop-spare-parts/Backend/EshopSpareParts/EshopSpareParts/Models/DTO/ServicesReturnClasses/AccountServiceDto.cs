using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO.ServicesReturnClasses
{
    public class AccountServiceDto
    {
        public UserDto UserDto { get; set; }

        public int StatusCode { get; set; }
    }
}