using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mango.Web.Domain;
using Mango.Web.Domain.DTOs;
using Mango.Web.Services.IServices;
using Newtonsoft.Json;

namespace Mango.Web.Services.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDto _response { get; set; }
        public IHttpClientFactory _httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this._response = new ResponseDto();
            this._httpClient = httpClient;
        }


        public async Task<T> SendAsync<T>(APIRequest request)
        {
            try
            {
                var client = _httpClient.CreateClient("MangoAPI");
                var message = new HttpRequestMessage();

                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(request.Url);
                
                client.DefaultRequestHeaders.Clear();

                if (request.Data != null)
                {
                    message.Content = new StringContent(
                        JsonConvert.SerializeObject(request.Data),
                        Encoding.UTF8,
                        "application/json");
                }

                HttpResponseMessage apiResponse = null;

                switch (request.CallType)
                {
                    case StaticDetails.CallType.POST:
                        message.Method = HttpMethod.Post;
                        break;

                    case StaticDetails.CallType.PUT:
                        message.Method = HttpMethod.Put;
                        break;

                    case StaticDetails.CallType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;

                    case StaticDetails.CallType.GET:
                        message.Method = HttpMethod.Get;
                        break;

                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDto;
            }
            catch (Exception e)
            {
                var dto = new ResponseDto()
                {
                    DisplayMessage = "Error",
                    ErrorMessages = new List<string>()
                    {
                        e.Message
                    },
                    IsSuccess = false
                };

                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
                return apiResponseDto;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(false);
        }
    }
}
