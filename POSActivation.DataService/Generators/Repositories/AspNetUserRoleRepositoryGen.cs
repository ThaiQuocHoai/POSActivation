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
    public partial interface IAspNetUserRoleRepository :IBaseRepository<AspNetUserRole>
    {
    }
    public partial class AspNetUserRoleRepository :BaseRepository<AspNetUserRole>, IAspNetUserRoleRepository
    {
         public AspNetUserRoleRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

