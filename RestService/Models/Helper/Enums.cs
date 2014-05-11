using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Helper
{
    public enum MessageTypeEnum
    {
        MSG,
        NOTICE
    }

    public enum OsEnum
    {
        WEB,
        ANDROID,
        IOS,
        WM
    }

    public enum LocalizationSourceEnum
    {
        GPS,
        GEOLOCATION,
        MAP
    }
}