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
    public partial interface IAspNetUserLoginService:IBaseService<AspNetUserLogin>
    {
    }
    public partial class AspNetUserLoginService:BaseService<AspNetUserLogin>,IAspNetUserLoginService
    {
        public AspNetUserLoginService(IUnitOfWork unitOfWork,IAspNetUserLoginRepository repository):base(unitOfWork,repository){}
    }
}
