namespace NewBench.Core
{
    /// <summary>
    /// 类似API的功能，只提供调用方法
    /// </summary>
    public class Coordinator
    {
        private readonly Instance _instance;

        public Coordinator(Instance instance)
        {
            _instance = instance;
        }

        public void DoSomething()
        {
            var domain = _instance.GetDomain<Domain>();
            if (domain == null) return;

            domain.CombineToOutputString();

            var business = _instance.GetBusiness<Business>();
            if (business == null) return;

            business.UsingModel(domain, "str1", "str2");
        }
    }
}
