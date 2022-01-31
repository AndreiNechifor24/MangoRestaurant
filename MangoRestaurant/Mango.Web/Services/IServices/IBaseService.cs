using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mango.Web.Models.DTOs;
using Mango.Web.Models;


namespace Mango.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto _response { get; set; }

        Task<T> SendAsync<T>(APIRequest request);

    }
}
