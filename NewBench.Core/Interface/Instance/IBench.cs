namespace NewBench.Base.Interface.Instance
{
    public interface IBench
    {
        T? GetCoordinator<T>() where T : ICoordinator;
        T? GetPublisher<T>() where T : IPublisher;
    }
}
