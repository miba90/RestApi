using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Helper
{
    public class Location
    {
        public int latitude { get; set; }
        public int longtitude { get; set; }
        public int precision { get; set; }
        public LocalizationSourceEnum source { get; set; }
    }
}