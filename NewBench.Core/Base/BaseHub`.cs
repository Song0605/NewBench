using NewBench.Core.Interface.Instance;

namespace NewBench.Core.Base
{
    public abstract class BaseHub<T> : IHub<T> where T : class
    {
        protected Dictionary<string, T> ValueDict { get; set; } = new();
        public abstract bool Register(string key, T value);
        public abstract bool Get(string key, out T? value);
    }
}