using NewBench.Core.Interface.Ability;
using NewBench.Core.Interface.Instance;

namespace NewBench.Core
{
    /// <summary>
    /// 类似API的功能，只提供调用方法
    /// </summary>
    public class Coordinator : ICoordinator,
                               ISupportInstanceContainer
    {
        private IInstanceContainer? _instanceContainer;

        public Coordinator() { }

        public void DoSomething()
        {
            var domain = _instanceContainer.GetDomain<Domain>();
            if (domain == null) return;

            domain.CombineToOutputString();

            var business = _instanceContainer.GetBusiness<Business>();
            if (business == null) return;

            business.UsingModel(domain, "str1", "str2");
        }

        public bool Register(IInstanceContainer instanceContainer)
        {
            _instanceContainer = instanceContainer;

            return _instanceContainer != null;
        }
    }
}
