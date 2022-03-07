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
    public partial interface ILocalMachineRepository :IBaseRepository<LocalMachine>
    {
    }
    public partial class LocalMachineRepository :BaseRepository<LocalMachine>, ILocalMachineRepository
    {
         public LocalMachineRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

