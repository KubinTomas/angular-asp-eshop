using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Files
{
    public class FolderUploadParametrs
    {
        public int? ItemId { get; set; }

        public int? ArticleId { get; set; }

        public bool? IsPreviewImage { get; set; }
    }
}