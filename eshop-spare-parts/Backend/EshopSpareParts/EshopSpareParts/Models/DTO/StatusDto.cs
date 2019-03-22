using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class StatusDto
    {
        public int id { get; set; }

        public string code { get; set; }

        public string name { get; set; }

        public const int Pending = 1;
        public const int Accepted = 2;
        public const int Finished = 3;
    }
}