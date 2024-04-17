using NewBench.Core.Base;
using NewBench.Core.Interface.Ability;
using NewBench.Core.Interface.Instance;

namespace NewBench.Core
{
    /// <summary>
    /// 领域对象
    /// 一：作为Business的整合，内部逻辑为调用流程；
    /// 二：作为类似Util的对象，在Model内部调用时，作为参数传入，协助函数处理
    /// </summary>
    public class Domain : IDomain, 
                          ISupportInstanceContainer
    {
        private InstanceContainer? _instanceContainer;

        public Domain() { }
        public void CombineToOutputString()
        {
            var business = _instanceContainer.GetBusiness<Business>();
            if (business == null) return;

            var str1 = business.GetStr1();
            var str2 = business.GetStr2();

            var result = Combine(str1, str2);

            var publisher = _instanceContainer.GetPublisher<Publisher>();
            if (publisher == null) return;

            publisher.OnSomethingPublished(this, new EventArgs<string>(result));
        }

        public string Combine(string str1, string str2)
        {
            return string.Concat(str1, str2);
        }

        /// <inheritdoc />
        public bool Register(IInstanceContainer instanceContainer)
        {
            _instanceContainer = instanceContainer;

            return _instanceContainer != null;
        }
    }
}
