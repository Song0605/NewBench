namespace NewBench.Core.Interface.Instance
{
    public interface IInstanceContainer
    {
        T? GetCoordinator<T>() where T : ICoordinator;

        T? GetPublisher<T>() where T : IPublisher;
        
        T? GetDomain<T>() where T : IDomain;

        T? GetBusiness<T>() where T : IBusiness;
        
        T? GetProcessor<T>() where T : IProcessor;
    }
}