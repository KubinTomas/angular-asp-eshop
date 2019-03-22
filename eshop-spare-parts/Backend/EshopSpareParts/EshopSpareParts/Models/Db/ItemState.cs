using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class ItemState
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public const int New = 1;
        public const int Used = 2;

    }
}