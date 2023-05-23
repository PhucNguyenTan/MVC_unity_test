using System;
using System.Collections.Generic;
using Unity.VisualScripting;

namespace Assets.Singleton
{
    //TODO: check if this work and how
    //referenced: https://csharpindepth.com/articles/Singleton
    public abstract class SingletonBase<T> where T: class, new()
    {
        public static readonly Lazy<T> lazy = new(() => new T());

        public static T Instance { get { return lazy.Value; } }

        protected SingletonBase()
        {
            Init();
        }

        protected virtual void Init()
        {
            // some code
        }
    }

    public sealed class TestSingleton : SingletonBase<TestSingleton>
    {

        protected override void Init()
        {
            base.Init();
        }
    }
}