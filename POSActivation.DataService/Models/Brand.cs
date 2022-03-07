using System;
using System.Collections.Generic;

#nullable disable

namespace POSActivation.DataService.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Stores = new HashSet<Store>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
