using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestService.Models.Conversation
{
    interface IMessageRepository
    {
        List<Message> Messages { get; set; }
        void Add(Message message);
        void Remove(int messageId);
    }
}
