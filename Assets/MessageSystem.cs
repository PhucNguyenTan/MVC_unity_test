using System;
using System.Collections.Generic;
using Assets.Singleton;
using UnityEngine;
using UnityEngine.Events;

namespace Assets
{
    public sealed class MessageManager : SingletonBase<MessageManager>
    {
        private static Dictionary<Type, Message> _eventDictionary = new();

        protected override void Init()
        {
            base.Init();
        }

        public void AddMessage<T>(T message)
            where T : Message
        {
            if (message is null)
                throw new ArgumentNullException("Message is null");
            _eventDictionary[typeof(T)] = message;
        }

        public void Subscribe<T>(T message)
        {
            _eventDictionary[typeof(T)].Invoke();
        }

        public void Invoke<T>(T tested) where T : Message
        {
            var test = tested as MessagePlayerMove;
            _eventDictionary[(uint)message.Identifier]
        }
    }

    public abstract class Message
    {
        protected Type _messageSender;
        protected Type _messageReceiver;
        protected MessageIdentifier _identifier;

        public MessageIdentifier Identifier { get { return _identifier; } }

        public Message(Type sender, Type receiver)
        {
            _messageSender = sender;
            _messageReceiver = receiver;
        }

        public abstract void Invoke();

        public abstract void Subscribe(UnityAction<Message> args);
    }

    public class MessagePlayerMove : Message
    {
        public UnityAction<Vector2> OnMessageReceived;
        public MessagePlayerMove(Type sender, Type receiver) : base(sender, receiver)
        { 
            _identifier = MessageIdentifier.PlayerMove;
        }

        public override void Invoke(Vector2 args)
        {
            OnMessageReceived.Invoke(args);
        }

        public override void Invoke<Vector2>(Vector2 args)
        {
            OnMessageReceived.Invoke(args);
        }

        public override void Subscribe(UnityAction<Vector2> args)
        {
            OnMessageReceived += args;
        }

        public override void Subscribe<T>(UnityAction<T> args)
        {
            throw new NotImplementedException();
        }
    }

    public enum MessageIdentifier
    {
        None = 0,
        PlayerMove
    }
}