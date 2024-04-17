using NewBench.Core.Interface.Instance;

namespace NewBench.Core
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
        public void Add(string type = "") => Dict.Add(type, Factory.CreateStr(type));
        public void Add(string key, string value) => Dict.Add(key, value);
        public string Get(string key) => Dict[key];
        public void Update(string key, string value) => Dict[key] = value;
        public void Delete(string key) => Dict.Remove(key);
        public Processor()
        {
            Add("str1");
            Add("str2");
        }
    }
}
