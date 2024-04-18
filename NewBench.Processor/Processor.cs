using NewBench.Base.Interface.Instance;
using NewBench.Factory;

namespace NewBench.Processor
{
    /// <summary>
    /// 提供各类对象在内存集合中的CRUD的标准流程
    /// </summary>
    public class Processor : IProcessor
    {
        /// <summary>
        /// 模拟内存中的数据集合
        /// </summary>
        public readonly Dictionary<string, string> Dict = new();
        public void Create(string type = "") => Dict.Add(type, StrFactory.CreateStr(type));
        public void Add(string key, string value) => Dict.Add(key, value);
        public string Get(string key) => Dict[key];
        public void Update(string key, string value) => Dict[key] = value;
        public void Delete(string key) => Dict.Remove(key);
        public Processor()
        {
            Create("str1");
            Create("str2");
        }
    }
}
