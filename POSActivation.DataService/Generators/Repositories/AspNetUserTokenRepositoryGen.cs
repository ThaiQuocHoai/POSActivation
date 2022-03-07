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
    public partial interface IAspNetUserTokenRepository :IBaseRepository<AspNetUserToken>
    {
    }
    public partial class AspNetUserTokenRepository :BaseRepository<AspNetUserToken>, IAspNetUserTokenRepository
    {
         public AspNetUserTokenRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

