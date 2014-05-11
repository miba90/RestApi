using Newtonsoft.Json;
using RestService.Models.Helper;
using RestService.Models.Login;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.SessionState;

namespace RestService.Controllers
{
    [SessionState(SessionStateBehavior.Required)]
    public class LoginController : ApiController
    {
        // POST api/login
        public HttpResponseMessage Post([FromBody]string s)
        {
            LoginInput input = JsonConvert.DeserializeObject<LoginInput>(s);
            if(ModelState.IsValid)
            {
                if (GlobalObjects.LoggedUsers.Contains(input.login))
                    return this.Request.CreateResponse(System.Net.HttpStatusCode.Conflict);
                else
                {
                    GlobalObjects.LoggedUser = input.login;
                    GlobalObjects.LoggedUsers.Add(input.login);
                }
            }

            var output = new LoginOutput200
            {
                serwerTime = Tools.ServerTime,
                version = input.version,
                isLogRcv = true,
                msg = "Elo"
            };
            var serial = JsonConvert.SerializeObject(output).Replace("\"", "'");
            return this.Request.CreateResponse(System.Net.HttpStatusCode.OK, serial);
        }
    }
}
