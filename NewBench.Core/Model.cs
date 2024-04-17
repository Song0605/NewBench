using NewBench.Core.Interface.Instance;

namespace NewBench.Core
{
    /// <summary>
    /// 看完DDD以后的设想；通过类的本身，依赖Domain完成函数。
    /// </summary>
    public class Model
    {
        public Model()
        {

        }
        public string GetCombineStr(IDomain domain, string str1, string str2)
        {
            return domain.Combine(str1, str2);
        }
    }
}
