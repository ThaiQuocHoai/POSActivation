using System;
using System.Collections.Generic;

#nullable disable

namespace POSActivation.DataService.Models
{
    public partial class LocalMachine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CpuCode { get; set; }
        public string DiskSerial { get; set; }
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}
