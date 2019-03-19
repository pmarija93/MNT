using System;
using System.Collections.Generic;

namespace MNT.Models
{
    public partial class SubWorkcenter
    {
        public int Id { get; set; }
        public string SubWorkcenterCode { get; set; }
        public string SubWorkcenterName { get; set; }
        public DateTime? SubWorkcenterAddDate { get; set; }
        public int? WorkcenterFk { get; set; }
    }
}
