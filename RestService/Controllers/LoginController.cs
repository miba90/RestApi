using Newtonsoft.Json;
using RestService.Models.Login;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace RestService.Controllers
{
    public class LoginController : ApiController
    {
        // POST api/login
        [HttpPost]
        public HttpResponseMessage Post([FromBody]string s)
        {
            LoginInput input = JsonConvert.DeserializeObject<LoginInput>(s);
            if(ModelState.IsValid)
            {
                var users = (List<string>)HttpContext.Current.Application["Users"];
                if (users.Contains(input.login))
                    return this.Request.CreateResponse(System.Net.HttpStatusCode.Conflict);
                else
                    users.Add(input.login);
            }

            return this.Request.CreateResponse(System.Net.HttpStatusCode.OK, JsonConvert.SerializeObject(input));
        }
    }
}
