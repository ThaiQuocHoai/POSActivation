
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
    public partial class AspNetUserClaim : IdentityUserClaim<string>
    {
      public virtual AspNetUser User { get; set; }
    }
}


