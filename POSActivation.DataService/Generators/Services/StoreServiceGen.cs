/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////
namespace POSActivation.DataService.Services
{
    using Reso.Core.BaseConnect;
    using POSActivation.DataService.Models;
    using POSActivation.DataService.Repositories;
    public partial interface IStoreService:IBaseService<Store>
    {
    }
    public partial class StoreService:BaseService<Store>,IStoreService
    {
        public StoreService(IUnitOfWork unitOfWork,IStoreRepository repository):base(unitOfWork,repository){}
    }
}
