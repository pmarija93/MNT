using System;
using System.Collections.Generic;

namespace MNT.Models
{
    public partial class ArticleSubWorkcenter
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public int? SubWorkcenterFk { get; set; }
    }
}
