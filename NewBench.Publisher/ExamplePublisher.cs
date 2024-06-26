﻿using System.Reflection;
using NewBench.Base.Interface.Instance;
using NewBench.Base.Object;

namespace NewBench.Publisher
{
    /// <summary>
    /// 只具有事件订阅与触发功能
    /// </summary>
    public class ExamplePublisher : IPublisher
    {
        public void PublishSomething(string message)
        {
            SomethingPublished?.Invoke(this, new EventArgs<string>(message));
        }
        public event EventHandler<EventArgs<string>>? SomethingPublished;

    }
}
