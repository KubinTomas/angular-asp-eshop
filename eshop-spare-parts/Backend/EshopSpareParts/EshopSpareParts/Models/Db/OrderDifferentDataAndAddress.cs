using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class OrderDifferentDataAndAddress
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public int Surname { get; set; }

        public int Email { get; set; }

        public int Phone { get; set; }

        public string Town { get; set; }

        public string TownNumber { get; set; }

        public string TownStreet { get; set; }
    }
}