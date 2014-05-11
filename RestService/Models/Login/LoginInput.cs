using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Login
{
    public class LoginInput
    {
        public string version { get; set; }
        public string os { get; set; }
        public string locale { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}