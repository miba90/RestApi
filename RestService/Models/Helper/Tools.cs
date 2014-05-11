using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Helper
{
    public static class Tools
    {
        public static int ServerTime
        {
            get
            {
                var ts = DateTime.UtcNow - new DateTime(1970, 01, 01, 0, 0, 0, DateTimeKind.Utc);
                return (int)ts.TotalSeconds;
            }
        }
    }
}