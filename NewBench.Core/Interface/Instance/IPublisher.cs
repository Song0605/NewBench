using NewBench.Base.Object;

namespace NewBench.Base.Interface.Instance
{
    public interface IPublisher
    {
        void PublishSomething(string message);
        event EventHandler<EventArgs<string>>? SomethingPublished;
    }
}
