using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class TransportCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public const int CeskaPosta = 1;
        public const int DPP = 2;
    }
}