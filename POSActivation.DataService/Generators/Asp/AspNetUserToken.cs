
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
    public partial class AspNetUserToken : IdentityUserToken<string>
    {
      public virtual AspNetUser User { get; set; }
    }
}


