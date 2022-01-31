using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Web
{
    public static class StaticDetails
    {
        public enum CallType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public static string ProductAPIBase { get; set; }
        
    }
}
