using System;
using System.Collections.Generic;

namespace MNT.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }
        public int? ArticleSubCategoryId { get; set; }
        public double? ArticleQuantity { get; set; }
        public DateTime? ArticleAddDate { get; set; }
        public DateTime? ArticleLastRevision { get; set; }
        public double? ArticleMinQunatity { get; set; }
        public int? ArticleShelfId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? SubWorkcenterFk { get; set; }
    }
}
