using System;
using System.Collections.Generic;
using Assets.MVC;
using Assets.Singleton;

namespace Assets
{
    public sealed class MessageManager : SingletonBase<MessageManager>
    {
        private readonly List<Message> _messages = new();

        protected override void Init()
        {
            base.Init();
        }

        public void AddMessage(Message message)
        {
            _messages.Add(message);
        }
    }

    public sealed class Message
    {
        private uint messageID;
        private Type messageSender;
        private Type messageReceiver;

        public Message(uint id, Type sender, Type receiver)
        {
            messageID = id;
            messageSender = sender;
            messageReceiver = receiver;
        }
    }
}