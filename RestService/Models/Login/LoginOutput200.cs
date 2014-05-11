using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Login
{
    public class LoginOutput200
    {
        public int serwerTime { get; set; }
        public string version { get; set; }
        public bool isLogRcv { get; set; }
        public string msg { get; set; }
    }
}