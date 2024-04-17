using NewBench.Core.Base;

namespace NewBench.Core.Interface.Instance
{
    public interface IPublisher
    {
        void PublishSomething(string message);
        event EventHandler<EventArgs<string>>? SomethingPublished;
    }
}
