using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class PersonalDataDto
    {
        public int id { get; set; }

        public int name { get; set; }

        public int surname { get; set; }

        public int email { get; set; }

        public int phone { get; set; }
    }
}