using System;
using static Mango.Web.StaticDetails;

namespace Mango.Web.Models
{
    public class APIRequest
    {
        public CallType CallType { get; set; } = CallType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
