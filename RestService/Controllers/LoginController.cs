using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RestService.Controllers
{
    public class LoginController : ApiController
    {
        // GET api/login
        public IEnumerable<string> Get()
        {
            var val = DateTime.UtcNow;
            return new string[] { "value1", "value2" };
        }

        // GET api/login/5
        public string Get(string val)
        {
            return "value " + val;
        }

        // POST api/login
        public void Post([FromBody]string ver, [FromBody]string os, [FromBody]string locale, [FromBody]string login, [FromBody]string password)
        {
        }

        // PUT api/login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/login/5
        public void Delete(int id)
        {
        }
    }
}
