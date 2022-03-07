using System;
using System.Collections.Generic;
using System.Text;

namespace POSActivation.DataService.RequestModel
{
    public class LocalMachineRequestModel
    {
        public int StoreId { get; set; }
        public string DiskSerial { get; set; }
        public string CPUCode { get; set; }
    }
}
