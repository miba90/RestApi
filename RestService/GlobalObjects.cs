using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace RestService
{
    public static class GlobalObjects
    {
        public static HashSet<string> LoggedUsers
        {
            get
            {
                if(HttpContext.Current.Application["Users"] == null)
                    HttpContext.Current.Application["Users"] = new HashSet<string>();

                return (HashSet<string>)HttpContext.Current.Application["Users"];
            }
        }

        public static string LoggedUser
        {
            get
            {
                var session = HttpContext.Current.Session;
                if (session == null)
                    throw new Exception("Sesja nie może być nullem");
                return (string)session["User"];
            }
            set
            {
                var session = HttpContext.Current.Session;
                if (session == null)
                    throw new Exception("Sesja nie może być nullem");
                session["User"] = value;
            }
        }
    }
}