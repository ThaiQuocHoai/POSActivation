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
    public partial interface ILocalMachineService:IBaseService<LocalMachine>
    {
    }
    public partial class LocalMachineService:BaseService<LocalMachine>,ILocalMachineService
    {
        public LocalMachineService(IUnitOfWork unitOfWork,ILocalMachineRepository repository):base(unitOfWork,repository){}
    }
}
