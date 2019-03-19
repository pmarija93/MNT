using System;
using System.Collections.Generic;

namespace MNT.Models
{
    public partial class Shelfs
    {
        public int Id { get; set; }
        public string ShelfCode { get; set; }
        public string ShelfName { get; set; }
        public int? ToolShelfId { get; set; }
    }
}
