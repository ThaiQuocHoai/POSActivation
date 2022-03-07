using System;
using System.Collections.Generic;

#nullable disable

namespace POSActivation.DataService.Models
{
    public partial class Store
    {
        public Store()
        {
            LocalMachines = new HashSet<LocalMachine>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ValidDate { get; set; }
        public bool? IsUsed { get; set; }
        public bool? IsAvailable { get; set; }
        public int? NumberOfPos { get; set; }
        public string StoreInfo { get; set; }
        public string PosConfig { get; set; }
        public string StoreCode { get; set; }
        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<LocalMachine> LocalMachines { get; set; }
    }
}
