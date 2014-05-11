using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestService.Models.Update;
using Newtonsoft.Json;
using RestService.Models.Conversation;
using RestService.Models.Helper;

namespace RestService.Controllers
{
    public class UpdateController : ApiController
    {
        // POST api/update
        public HttpResponseMessage Post([FromBody]string value)
        {
            UpdateInput input = JsonConvert.DeserializeObject<UpdateInput>(value);

            IMessageRepository mr = new MessageRepositoryHardcoded();
            UpdateOutput uo = new UpdateOutput
            {
                messages = mr.Messages,
                serverTime = Tools.ServerTime
            };

            string json = JsonConvert.SerializeObject(uo);
            return this.Request.CreateResponse(HttpStatusCode.OK, json);
        }
    }
}
