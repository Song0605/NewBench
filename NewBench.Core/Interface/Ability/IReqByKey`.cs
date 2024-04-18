namespace NewBench.Base.Interface.Ability
{
    public interface IReqByKey<out T> where T : class
    {
        T? GetInstance(string key);
    }
}