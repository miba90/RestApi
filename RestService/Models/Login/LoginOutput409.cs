using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Login
{
    /// <summary>
    /// obiekt zwracany gdy login jest powielony
    /// </summary>
    public class LoginOutput409
    {
        public int serwerTime { get; set; }
        public string newLogin { get; set; }
    }
}