using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string FilterWord { get; set; }

        public bool IsVisible { get; set; }

        public virtual Category Parent { get; set; }
        public int? ParentId { get; set; }

    }
}