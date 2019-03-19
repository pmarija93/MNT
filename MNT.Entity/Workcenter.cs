using System;
using System.Collections.Generic;

namespace MNT.Models
{
    public partial class Workcenter
    {
        public int Id { get; set; }
        public string WorkcenterCode { get; set; }
        public string WorkcenterName { get; set; }
        public DateTime? WorkcenterAddDate { get; set; }
        public int? LocationId { get; set; }
    }
}
