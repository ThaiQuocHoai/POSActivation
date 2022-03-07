using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using POSActivation.DataService.RequestModel;
using POSActivation.DataService.Services;
using POSActivation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSActivation.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/stores")]
    [ApiController]
    [Authorize]
    public class StoreControllers : ControllerBase
    {
        private readonly IStoreService storeService;
        public StoreControllers(IStoreService _storeService)
        {
            storeService = _storeService;
        }

        [HttpGet("{id}/store-info")]
        [AllowAnonymous]
        public IActionResult GetStoreInfo(int id)
        {
            string storeInfo = storeService.GetStoreConfig(id);

            if (storeInfo == null || storeInfo != null && storeInfo.Length < 1)
                return BadRequest("Store id is not valid");
            return File(new System.Text.UTF8Encoding().GetBytes(storeInfo), "text/plain", "StoreInfo.json");
        }

        [HttpGet("{id}/pos-config")]
        [AllowAnonymous]
        public IActionResult GetPosConfig(int id)
        {
            string posConfig = storeService.GetPosConfig(id);

            if (posConfig == null || posConfig != null && posConfig.Length < 1)
                return BadRequest("Store id is not valid");
            return File(new System.Text.UTF8Encoding().GetBytes(posConfig), "text/plain", "posConfig.json");
        }

        [HttpPut("{id}/pos-config")]
        public IActionResult SetPosConfig(int id, PosConfigRequestModel posConfig)
        {
            storeService.SetPosConfig(id, posConfig);
            return Ok();
        }
        [HttpPut("{id}/store-info")]
        public IActionResult SetStoreInfo(int id, StoreInfoRequestModel storeInfo)
        {
            storeService.SetStoreInfo(id, storeInfo);
            return Ok();
        }
        /// <summary>
        /// Update validDate extra 30 days
        /// </summary>
        [HttpPut("{id}/extra-valid-date-quantity")]
        public IActionResult ExtraValidDateQuantity(int id)
        {
            var result = storeService.ValidationDate(id);
            if (result)
            {
                return Ok("Successfully added 30 days");
            }
            return BadRequest("Cannot find this store");
        }
        /// <summary>
        /// Update ValidDate from chooser
        /// </summary>
        [HttpPut("extra-valid-date")]
        public IActionResult ExtraValidDate(StoreValidDateRequestModel model)
        {
            var result = storeService.ValidationDate(model);
            if (result)
            {
                return Ok("Successfully added");
            }
            return BadRequest("Add fail");
        }
    }
}
