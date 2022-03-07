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
    public partial interface IAspNetUserLoginRepository :IBaseRepository<AspNetUserLogin>
    {
    }
    public partial class AspNetUserLoginRepository :BaseRepository<AspNetUserLogin>, IAspNetUserLoginRepository
    {
         public AspNetUserLoginRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

