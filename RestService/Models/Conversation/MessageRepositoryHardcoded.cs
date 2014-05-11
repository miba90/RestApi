using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models.Conversation
{
    public class MessageRepositoryHardcoded : IMessageRepository
    {
        List<Message> messages = new List<Message>
        {
            new Message{messageId = 1, type = Message.TypeEnum.MSG, nick = "Dżoanna", message = "Elo", distance = 1000,
                localizationSource = Message.LocalizationSourceEnum.GEOLOCATION, parentId = null, sourceOs = Message.OsEnum.ANDROID},

            new Message{messageId = 2, type = Message.TypeEnum.MSG, nick = "Jaro", message = "Zgubiłem psa", distance = 100,
                localizationSource = Message.LocalizationSourceEnum.GPS, parentId = null, sourceOs = Message.OsEnum.ANDROID},

            new Message{messageId = 5, type = Message.TypeEnum.MSG, nick = "BigDick", message = "Poznajmy się", distance = 555,
                localizationSource = Message.LocalizationSourceEnum.MAP, parentId = 1, sourceOs = Message.OsEnum.ANDROID},
        };

        public List<Message> Messages
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public void Add(Message message)
        {
            throw new NotImplementedException();
        }


        public void Remove(int messageId)
        {
            throw new NotImplementedException();
        }
    }
}