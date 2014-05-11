using RestService.Models.Conversation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Update
{
    public class UpdateOutput
    {
        public int serverTime { get; set; }
        public List<Message> messages { get; set; }
    }
}