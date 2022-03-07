using AutoMapper;
using AutoMapper.QueryableExtensions;
using Nancy.Json;
using Newtonsoft.Json;
using POSActivation.DataService.Models;
using POSActivation.DataService.Repositories;
using POSActivation.DataService.RequestModel;
using POSActivation.ViewModels;
using Reso.Core.BaseConnect;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace POSActivation.DataService.Services
{

    public partial interface IStoreService
    {
        string GetStoreConfig(int storeId);
        string GetPosConfig(int storeId);
        void SetPosConfig(int storeId, PosConfigRequestModel posConfig);
        void SetStoreInfo(int storeId, StoreInfoRequestModel storeInfo);

        bool ValidationDate(int storeId);
        bool ValidationDate(StoreValidDateRequestModel model);

    }

    public partial class StoreService : IStoreService
    {
        private readonly IConfigurationProvider _mapper;

        public StoreService(IMapper mapper, IUnitOfWork unitOfWork, IStoreRepository repository)
            : base(unitOfWork, repository)
        {
            _mapper = mapper.ConfigurationProvider;
        }

        public string GetPosConfig(int storeId)
        {
            var store = FirstOrDefault(x => x.Id == storeId);
            string posConfig = null;
            if (store != null)
            {
                posConfig = store.PosConfig;
            }

            return posConfig;
        }

        public string GetStoreConfig(int storeId)
        {
            var store = FirstOrDefault(x => x.Id == storeId);
            string storeInfo = null;
            if (store != null)
            {
                storeInfo = store.StoreInfo;
            }

            return storeInfo;
        }

        public void SetPosConfig(int storeId, PosConfigRequestModel posConfig)
        {
            var store = Get(x => x.Id == storeId).FirstOrDefault();
            if (store == null) return;
            var js = new JavaScriptSerializer();
            var pos = js.Serialize(posConfig);
            string str = null;
            var json = js.DeserializeObject(pos);
            str = json.ToString();
            store.PosConfig = str;
            Update(store);
            Save();
        }

        public void SetStoreInfo(int storeId, StoreInfoRequestModel storeInfo)
        {
            var store = FirstOrDefault(x => x.Id == storeId);
            if (store == null) return;
            var js = new JavaScriptSerializer();
            var storeObj = js.Serialize(storeInfo);
            string str = null;
            var json = js.DeserializeObject(storeObj);
            str = json.ToString();
            store.StoreInfo = str;
            Update(store);
            Save();
        }

        public bool ValidationDate(int storeId)
        {
            var store = FirstOrDefault(x => x.Id == storeId);
            if (store == null) return false;
            var date = store.ValidDate?.AddDays(30);
            store.ValidDate = date;
            Save();
            return true;
        }

        public bool ValidationDate(StoreValidDateRequestModel model)
        {
            DateTime now = DateTime.UtcNow;
            //check input validation input datetime
            if (DateTime.Compare(model.ValidDate, now) <= 0)
                return false;
            var entity = FirstOrDefault(x => x.Id == model.Id);
            if (entity == null) return false;
            entity.ValidDate = model.ValidDate;
            Save();
            return true;
        }
    }
}
