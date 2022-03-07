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
    public partial interface IAspNetRoleService:IBaseService<AspNetRole>
    {
    }
    public partial class AspNetRoleService:BaseService<AspNetRole>,IAspNetRoleService
    {
        public AspNetRoleService(IUnitOfWork unitOfWork,IAspNetRoleRepository repository):base(unitOfWork,repository){}
    }
}
