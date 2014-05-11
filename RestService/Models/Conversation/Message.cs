using RestService.Models.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Conversation
{
    public class Message
    {
        public int messageId { get; set; }
        public int? parentId { get; set; }
        public MessageTypeEnum type { get; set; }
        public string nick { get; set; }
        public string message { get; set; }
        public byte[] content { get; set; }
        public decimal distance { get; set; }
        public OsEnum sourceOs { get; set; }
        public LocalizationSourceEnum localizationSource { get; set; }

    }
}