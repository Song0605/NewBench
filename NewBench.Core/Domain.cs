using NewBench.Core.Base;

namespace NewBench.Core
{
    /// <summary>
    /// 领域对象
    /// 一：作为Business的整合，内部逻辑为调用流程；
    /// 二：作为类似Util的对象，在Model内部调用时，作为参数传入，协助函数处理
    /// </summary>
    public class Domain
    {
        private readonly Instance _instance;

        public Domain(Instance instance)
        {
            _instance = instance;
        }
        public void CombineToOutputString()
        {
            var business = _instance.GetBusiness<Business>();
            if (business == null) return;

            var str1 = business.GetStr1();
            var str2 = business.GetStr2();

            var result = Combine(str1, str2);

            var publisher = _instance.GetPublisher<Publisher>();
            if (publisher == null) return;

            publisher.OnSomethingPublished(this, new EventArgs<string>(result));
        }

        public string Combine(string str1, string str2)
        {
            return string.Concat(str1, str2);
        }
    }
}
