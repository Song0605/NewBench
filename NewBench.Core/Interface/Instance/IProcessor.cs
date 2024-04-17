namespace NewBench.Core.Interface.Instance
{
    public interface IProcessor
    {
        void Create(string type = "");
        void Add(string key, string value);
        string Get(string key);
        void Update(string key, string value);
        void Delete(string key);
    }
}