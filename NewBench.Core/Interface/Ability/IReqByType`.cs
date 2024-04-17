using NewBench.Core.Interface.Instance;

namespace NewBench.Core.Interface.Ability
{
    public interface IReqByType<out T> where T : class
    {
        T? GetInstance<TReq>();
    }
}
