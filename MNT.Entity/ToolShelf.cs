using System;
using System.Collections.Generic;

namespace MNT.Models
{
    public partial class ToolShelf
    {
        public int Id { get; set; }
        public string Tscode { get; set; }
        public string Tsname { get; set; }
        public int? WarehouseId { get; set; }
    }
}
