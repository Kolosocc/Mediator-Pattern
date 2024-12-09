using ChatSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern_Chat
{

    internal class User
    {
        public string Name { get; private set; }
        private ChatMediator _mediator;

        public User(string name, ChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void SendMessage(string message, string recipientName)
        {
            Console.WriteLine($"{Name} отправляет сообщение: \"{message}\" получателю: {recipientName}");
            _mediator.SendMessage(this, message, recipientName);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            Console.WriteLine($"{Name} получил сообщение от {senderName}: \"{message}\"");
        }
    }
}
