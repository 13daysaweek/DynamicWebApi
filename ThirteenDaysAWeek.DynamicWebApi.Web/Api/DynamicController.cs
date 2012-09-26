using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace ThirteenDaysAWeek.DynamicWebApi.Web.Api
{
    public class DynamicController : ApiController
    {
        public JObject Post([FromBody]JObject json)
        {
            dynamic newJson = json;

            newJson.NewProperty = "Something";
            newJson.Date = DateTime.Now;

            return newJson;
        }       
    }
}
