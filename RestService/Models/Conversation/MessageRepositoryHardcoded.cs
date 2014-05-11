using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestService.Models.Helper;

namespace RestService.Models.Conversation
{
    public class MessageRepositoryHardcoded : IMessageRepository
    {
        List<Message> messages = new List<Message>
        {
            new Message{messageId = 1, type = MessageTypeEnum.MSG, nick = "Dżoanna", message = "Elo", distance = 1000,
                localizationSource = LocalizationSourceEnum.GEOLOCATION, parentId = null, sourceOs = OsEnum.ANDROID},

            new Message{messageId = 2, type = MessageTypeEnum.MSG, nick = "Jaro", message = "Zgubiłem psa", distance = 100,
                localizationSource = LocalizationSourceEnum.GPS, parentId = null, sourceOs = OsEnum.ANDROID},

            new Message{messageId = 5, type = MessageTypeEnum.MSG, nick = "BigDick", message = "Poznajmy się", distance = 555,
                localizationSource = LocalizationSourceEnum.MAP, parentId = 1, sourceOs = OsEnum.ANDROID},
        };

        public List<Message> Messages
        {
            get
            {
                return messages;
            }
        }


        public void Add(Message message)
        {
            messages.Add(message);
        }


        public void Remove(int messageId)
        {
            messages.Remove(messages.Single(a => a.messageId == messageId));
        }
    }
}