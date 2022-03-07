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
    public partial interface IStoreRepository :IBaseRepository<Store>
    {
    }
    public partial class StoreRepository :BaseRepository<Store>, IStoreRepository
    {
         public StoreRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

