using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class CategoryDto
    {
        public int id { get; set; }

        public string title { get; set; }

        public string filterWord { get; set; }

        public bool isVisible { get; set; }

        public int? parentId { get; set; }

        public CategoryDto parent { get; set; }

        public List<CategoryDto> CategoriesDto { get; set; }
    }
}