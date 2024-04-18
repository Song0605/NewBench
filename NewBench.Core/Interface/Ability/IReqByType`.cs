namespace NewBench.Base.Interface.Ability
{
    public interface IReqByType<out T> where T : class
    {
        T? GetInstance<TReq>();
    }
}
