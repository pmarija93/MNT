using System;
using System.Collections.Generic;

namespace MNT.Models
{
    public partial class ArticleSubCategory
    {
        public int Id { get; set; }
        public int ArticleCategoryId { get; set; }
        public string ArticleSubCategoryCode { get; set; }
        public string ArticleSubCategoryName { get; set; }
    }
}
