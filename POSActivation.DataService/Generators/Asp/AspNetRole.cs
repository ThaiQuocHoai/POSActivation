

/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////


using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

#nullable disable

namespace POSActivation.DataService.Models
{
    public partial class AspNetRole : IdentityRole<string>
    {
        public AspNetRole()
        {
            AspNetRoleClaims = new HashSet<AspNetRoleClaim>();
            AspNetUserRoles = new HashSet<AspNetUserRole>();
        }

        public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
    }
}


