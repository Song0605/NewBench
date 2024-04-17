using NewBench.Core.Base;

namespace NewBench.Core.Interface.Instance
{
    public interface IPublisher
    {
        event EventHandler<EventArgs<string>>? SomethingPublished;
    }
}
