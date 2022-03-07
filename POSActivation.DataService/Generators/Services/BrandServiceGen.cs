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
    public partial interface IBrandService:IBaseService<Brand>
    {
    }
    public partial class BrandService:BaseService<Brand>,IBrandService
    {
        public BrandService(IUnitOfWork unitOfWork,IBrandRepository repository):base(unitOfWork,repository){}
    }
}
