using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBench.Core.Base;
using NewBench.Core.Interface.Instance;

namespace NewBench.Core
{
    /// <summary>
    /// 只具有事件订阅与触发功能
    /// </summary>
    public class Publisher : IPublisher
    {
        public event EventHandler<EventArgs<string>>? SomethingPublished;
        public void OnSomethingPublished(object sender, EventArgs<string> e)
        {
            SomethingPublished?.Invoke(sender, e);
        }
    }
}
