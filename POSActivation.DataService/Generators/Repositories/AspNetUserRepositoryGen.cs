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
    public partial interface IAspNetUserRepository :IBaseRepository<AspNetUser>
    {
    }
    public partial class AspNetUserRepository :BaseRepository<AspNetUser>, IAspNetUserRepository
    {
         public AspNetUserRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

