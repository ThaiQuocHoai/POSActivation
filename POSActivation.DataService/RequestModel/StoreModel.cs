using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSActivation.ViewModels
{
    public class StoreModel
    {
        //public StoreModel()
        //{
        //    LocalMachines = new HashSet<LocalMachineModel>();
        //}
        public int Id { get; set; }
        public int NumberOfPos { get; set; }
        public ICollection<LocalMachineModel> LocalMachines { get; set; }
    }
    public class LocalMachineModel
    {
        public string CpuCode { get; set; }
        public string DiskSerial { get; set; }
        public int StoreId { get; set; }
    }

    public class StoreValidDateRequestModel
    {
        public int Id { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
