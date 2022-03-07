using AutoMapper;
using AutoMapper.QueryableExtensions;
using POSActivation.DataService.Models;
using POSActivation.DataService.Repositories;
using POSActivation.DataService.RequestModel;
using POSActivation.ViewModels;
using Reso.Core.BaseConnect;
using System;
using System.Linq;

namespace POSActivation.DataService.Services
{
    public partial interface ILocalMachineService
    {
        bool CheckValidationKey(LocalMachineRequestModel model);
    }
    public partial class LocalMachineService : ILocalMachineService
    {

        //private readonly POSActivationDBContext _context;
        private readonly IConfigurationProvider _mapper;
        private readonly IStoreService _storeService;

        public LocalMachineService(IUnitOfWork unitOfWork, ILocalMachineRepository repository, IMapper mapper, IStoreService storeService)
            : base(unitOfWork, repository)
        {
            _mapper = mapper.ConfigurationProvider;
            _storeService = storeService;
        }

        //public LocalMachineService(POSActivationDBContext context , IMapper mapper)
        //{
        //    _context = context;
        //    _mapper = mapper.ConfigurationProvider;
        //}

        public bool CheckValidationKey(LocalMachineRequestModel model)
        {
            DateTime now = DateTime.UtcNow;
            #region get valid store is using
            var store = _storeService.Get(x => x.Id == model.StoreId && DateTime.Compare((DateTime)x.ValidDate, now) >= 0
                && x.IsAvailable == true && x.IsUsed != false)
                //.Include(i => i.LocalMachines)
                .ProjectTo<StoreModel>(_mapper)
                .FirstOrDefault();
            //var test = _context.Stores.Where(x => x.Id == model.StoreId && DateTime.Compare(x.ValidDate, now) >= 0
            //&& x.IsAvailable == true && x.IsUsed == true)
            //.ProjectTo<StoreModel>(_mapper)
            //.FirstOrDefault();
            #endregion
            if (store == null) //No store valid
                return false;
            #region if field numberofpos of Store == number of current pos same store id => check code
            if (store.NumberOfPos == store.LocalMachines.Count)
            {
                var localmachine = store.LocalMachines.Any(k => k.CpuCode.Equals(model.CPUCode)
                && k.DiskSerial.Equals(model.DiskSerial));
                return localmachine;
            }
            #endregion

            #region NumberOfPos < number of current pos => check code is existed
            var existCode = store.LocalMachines.FirstOrDefault(k => k.CpuCode.Equals(model.CPUCode)
                    && k.DiskSerial.Equals(model.DiskSerial));
            if (existCode != null) return true;


            #endregion

            #region NumberOfPos < number of current pos => check code is not existed => create a new pos
            var pos1 = new LocalMachine()
            {
                Name = "pos" + Guid.NewGuid().ToString(),
                CpuCode = model.CPUCode,
                DiskSerial = model.DiskSerial,
                StoreId = model.StoreId
            };
            Create(pos1);
            Save();
            #endregion

            return true;
        }

    }
}
