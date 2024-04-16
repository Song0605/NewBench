using NewBench.Core;

namespace NewBench.API
{
    /// <summary>
    /// 中台与UI（或外部组件）的中转站，通过Coordinator.Command与Publisher.Event间接建立通信关系。
    /// </summary>
    public class Bench
    {
        private readonly Instance _instance;
        public Bench()
        {
            _instance = new Instance();
        }

        public Coordinator? GetCoordinator<T>() where T : Coordinator
        {
            return _instance.GetCoordinator<T>();
        }

        public Publisher? GetPublisher<T>() where T : Publisher
        {
            return _instance.GetPublisher<T>();
        }
    }
}
