using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO.ServicesReturnClasses
{
    public class ArticleServiceDto
    {
        public ArticleDto ArticleDto { get; set; }

        public List<ArticleDto> ArticlesDto { get; set; }

        public int StatusCode { get; set; }
    }
}