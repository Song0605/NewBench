namespace NewBench.Core
{
    /// <summary>
    /// 类似Tipbox，在自己内部依赖Domain完成函数。
    /// </summary>
    public class Model
    {
        public Model()
        {

        }
        public string GetCombineStr(Domain domain, string str1, string str2)
        {
            return domain.Combine(str1, str2);
        }
    }
}
