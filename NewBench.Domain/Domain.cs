using NewBench.Base.Interface.Ability;
using NewBench.Base.Interface.Instance;

namespace NewBench.Domain
{
    /// <summary>
    /// 领域对象
    /// 一：作为Business的整合，内部逻辑为调用流程；
    /// 二：（设想）作为类似Util的对象，在Model内部调用时，作为参数传入，协助函数处理
    /// </summary>
    public class Domain : IDomain,
                          ISupportInstanceContainer
    {
        private IInstanceContainer? _instanceContainer;

        public Domain() { }
        public void CombineToOutputString()
        {
            if (_instanceContainer == null) return;
            var business = _instanceContainer.GetBusiness<IBusiness>();
            if (business == null) return;

            var str1 = business.GetStr1();
            var str2 = business.GetStr2();

            var result = Combine(str1, str2);

            var publisher = _instanceContainer.GetPublisher<IPublisher>();
            if (publisher == null) return;

            publisher.PublishSomething(result);
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
