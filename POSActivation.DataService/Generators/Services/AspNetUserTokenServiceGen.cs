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
    public partial interface IAspNetUserTokenService:IBaseService<AspNetUserToken>
    {
    }
    public partial class AspNetUserTokenService:BaseService<AspNetUserToken>,IAspNetUserTokenService
    {
        public AspNetUserTokenService(IUnitOfWork unitOfWork,IAspNetUserTokenRepository repository):base(unitOfWork,repository){}
    }
}
