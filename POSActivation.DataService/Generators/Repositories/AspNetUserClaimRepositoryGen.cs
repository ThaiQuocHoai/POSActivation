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
    public partial interface IAspNetUserClaimRepository :IBaseRepository<AspNetUserClaim>
    {
    }
    public partial class AspNetUserClaimRepository :BaseRepository<AspNetUserClaim>, IAspNetUserClaimRepository
    {
         public AspNetUserClaimRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

