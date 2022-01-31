using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mango.Web.Domain;
using Mango.Web.Domain.DTOs;

namespace Mango.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto _response { get; set; }

        Task<T> SendAsync<T>(APIRequest request);

    }
}
