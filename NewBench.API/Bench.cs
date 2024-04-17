using NewBench.Core;
using NewBench.Core.Interface.Instance;

namespace NewBench.API
{
    /// <summary>
    /// 中台与UI（或外部组件）的交互层，通过Coordinator.Command与Publisher.Event间接建立通信关系。
    /// </summary>
    public sealed class Bench : IBench
    {
        private readonly IInstanceContainer _instanceContainerContainer;

        public Bench()
        {
            _instanceContainerContainer = new InstanceContainer();
        }

        #region Implementation of IBench

        /// <inheritdoc />
        public T? GetCoordinator<T>() where T : ICoordinator
        {
            return _instanceContainerContainer.GetCoordinator<T>();
        }

        /// <inheritdoc />
        public T? GetPublisher<T>() where T : IPublisher
        {
            return _instanceContainerContainer.GetPublisher<T>();
        }

        #endregion
    }
}
