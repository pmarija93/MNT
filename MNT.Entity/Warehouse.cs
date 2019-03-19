using System;
using System.Collections.Generic;

namespace MNT.Models
{
    public partial class Warehouse
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
    }
}
