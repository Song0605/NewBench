namespace NewBench.Core.Hub
{
    /// <summary>
    /// 保存各类Service信息
    /// </summary>
    public static class ServiceHub
    {
        public static Dictionary<string, Func<string>> ServiceDict { get; set; } = new();
        static ServiceHub() { }
        public static void Register(string key, Func<string> func) => ServiceDict.Add(key, func);
        public static Func<string> Get(string key) => ServiceDict[key];
    }
}
