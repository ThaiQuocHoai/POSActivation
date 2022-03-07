/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////

using Microsoft.EntityFrameworkCore;
using Reso.Core.BaseConnect;
using POSActivation.DataService.Models;
namespace POSActivation.DataService.Repositories
{
    public partial interface IAspNetRoleClaimRepository :IBaseRepository<AspNetRoleClaim>
    {
    }
    public partial class AspNetRoleClaimRepository :BaseRepository<AspNetRoleClaim>, IAspNetRoleClaimRepository
    {
         public AspNetRoleClaimRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

