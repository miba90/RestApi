using Newtonsoft.Json;
using RestService.Models.Helper;
using RestService.Models.Logout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.SessionState;

namespace RestService.Controllers
{
    [SessionState(SessionStateBehavior.Required)]
    public class LogoutController : ApiController
    {
        // GET api/logout
        public HttpResponseMessage Get()
        {
            var output = new LogoutOutput
            {
                serverTime = Tools.ServerTime
            };

            GlobalObjects.LoggedUsers.Remove(GlobalObjects.LoggedUsers.Single(a => a == GlobalObjects.LoggedUser));

            var serial = JsonConvert.SerializeObject(output);
            return this.Request.CreateResponse(HttpStatusCode.OK, serial);
        }
    }
}
