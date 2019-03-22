using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class Article
    {
        public int Id { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public string ImagePath { get; set; }

        public DateTime Created { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}