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
    public partial interface IAspNetUserService:IBaseService<AspNetUser>
    {
    }
    public partial class AspNetUserService:BaseService<AspNetUser>,IAspNetUserService
    {
        public AspNetUserService(IUnitOfWork unitOfWork,IAspNetUserRepository repository):base(unitOfWork,repository){}
    }
}
