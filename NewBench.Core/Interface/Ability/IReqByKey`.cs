using NewBench.Core.Interface.Instance;

namespace NewBench.Core.Interface.Ability
{
    public interface IReqByKey<out T> where T : class
    {
        T? GetInstance(string key);
    }
}