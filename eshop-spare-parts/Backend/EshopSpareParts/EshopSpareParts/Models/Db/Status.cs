using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class Status
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public const int Pending = 1;
        public const int Accepted = 2;
        public const int Finished = 3;
    }
}