using NewBench.Core.Interface.Ability;
using NewBench.Core.Interface.Instance;

namespace NewBench.Coordinator
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
            var domain = _instanceContainer.GetDomain<IDomain>();
            if (domain == null) return;

            domain.CombineToOutputString();

            var business = _instanceContainer.GetBusiness<IBusiness>();
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
