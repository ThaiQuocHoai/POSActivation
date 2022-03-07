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
    public partial interface IAspNetRoleRepository :IBaseRepository<AspNetRole>
    {
    }
    public partial class AspNetRoleRepository :BaseRepository<AspNetRole>, IAspNetRoleRepository
    {
         public AspNetRoleRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

