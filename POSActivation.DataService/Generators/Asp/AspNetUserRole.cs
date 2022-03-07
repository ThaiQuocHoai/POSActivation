
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
    public partial class AspNetUserRole : IdentityUserRole<string>
    {
      public virtual AspNetRole Role { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}


