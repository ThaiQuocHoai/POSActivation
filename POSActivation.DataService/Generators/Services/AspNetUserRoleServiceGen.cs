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
    public partial interface IAspNetUserRoleService:IBaseService<AspNetUserRole>
    {
    }
    public partial class AspNetUserRoleService:BaseService<AspNetUserRole>,IAspNetUserRoleService
    {
        public AspNetUserRoleService(IUnitOfWork unitOfWork,IAspNetUserRoleRepository repository):base(unitOfWork,repository){}
    }
}
