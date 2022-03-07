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
    public partial interface IAspNetRoleClaimService:IBaseService<AspNetRoleClaim>
    {
    }
    public partial class AspNetRoleClaimService:BaseService<AspNetRoleClaim>,IAspNetRoleClaimService
    {
        public AspNetRoleClaimService(IUnitOfWork unitOfWork,IAspNetRoleClaimRepository repository):base(unitOfWork,repository){}
    }
}
