using RestService.Models.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Update
{
    public class UpdateInput
    {
        public int since { get; set; }
        public Location location { get; set; }
        public string ignoredConversations { get; set; }
        public int startFrom { get; set; }
        public int messagesCount { get; set; }
    }
}