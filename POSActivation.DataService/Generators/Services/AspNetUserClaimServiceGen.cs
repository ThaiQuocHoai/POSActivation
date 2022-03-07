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
    public partial interface IAspNetUserClaimService:IBaseService<AspNetUserClaim>
    {
    }
    public partial class AspNetUserClaimService:BaseService<AspNetUserClaim>,IAspNetUserClaimService
    {
        public AspNetUserClaimService(IUnitOfWork unitOfWork,IAspNetUserClaimRepository repository):base(unitOfWork,repository){}
    }
}
