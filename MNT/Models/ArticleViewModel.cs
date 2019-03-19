using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNT.Models
{
    public class ArticleViewModel
    {
        public int ID { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleName { get; set; }
        public IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> lista { get; set; }
    }
}
