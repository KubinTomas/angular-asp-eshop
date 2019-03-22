using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class ArticleDto
    {
        public int id { get; set; }

        public string header { get; set; }

        public string content { get; set; }

        public string imagePath { get; set; }

        public DateTime created { get; set; }

        public int userId { get; set; }
    }
}