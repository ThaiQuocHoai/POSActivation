using Microsoft.AspNetCore.Identity;
using POSActivation.DataService.Commons;
using POSActivation.DataService.Models;
using POSActivation.DataService.Repositories;
using Reso.Core.BaseConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSActivation.DataService.Services
{
    public partial interface IAspNetUserService
    {
        Task<string> LoginAsync(AspNetUser asp);

        //Task<string> RegisterAsync(AspNetUser asp);
    }

    public partial class AspNetUserService : IAspNetUserService
    {

        public async Task<string> LoginAsync(AspNetUser asp)
        {
            return null;
        }

        //public Task<string> RegisterAsync(AspNetUser asp)
        //{

        //}
    }
}
