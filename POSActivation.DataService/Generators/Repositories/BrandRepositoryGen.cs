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
    public partial interface IBrandRepository :IBaseRepository<Brand>
    {
    }
    public partial class BrandRepository :BaseRepository<Brand>, IBrandRepository
    {
         public BrandRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

