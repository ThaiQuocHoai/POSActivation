using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using POSActivation.DataService.Models;
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
    [Route("api/v{version:apiVersion}/local-machines")]
    [ApiController]
    public class LocalMachineControllers : ControllerBase
    {
        private readonly ILocalMachineService _localMachineService;
        public LocalMachineControllers(ILocalMachineService localMachineService)
        {
            _localMachineService = localMachineService;
        }

        [HttpPost("validation-key")]
        public IActionResult CheckKey(LocalMachineRequestModel localMachine)
        {
            bool check = _localMachineService.CheckValidationKey(localMachine);
            if(check)
            {
                return Ok();
            }
            return BadRequest("Code is not available");
        }

    }
}
