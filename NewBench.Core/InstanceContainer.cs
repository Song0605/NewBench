﻿using NewBench.Core.Interface.Ability;
using NewBench.Core.Interface.Instance;

namespace NewBench.Core
{
    /// <summary>
    /// 管理实例对象
    /// </summary>
    public class InstanceContainer : IInstanceContainer
    {
        private readonly ICoordinator _coordinator;
        private readonly IPublisher _publisher;
        private readonly IDomain _domain;
        private readonly IBusiness _business;
        private readonly IProcessor _processor;

        public InstanceContainer()
        {
            _coordinator = new Coordinator();
            if (_coordinator is ISupportInstanceContainer { } supportInstance1)
                supportInstance1.Register(this);

            _publisher = new Publisher();

            _domain = new Domain();
            if (_domain is ISupportInstanceContainer { } supportInstance2)
                supportInstance2.Register(this);

            _business = new Business();
            if (_business is ISupportInstanceContainer { } supportInstance)
                supportInstance.Register(this);

            _processor = new Processor();
        }
        
        #region Implementation of IInstance

        /// <inheritdoc />
        public T? GetCoordinator<T>() where T : ICoordinator
        {
            if (typeof(T).IsAssignableTo(typeof(ICoordinator)))
                return (T?)_coordinator;

            return default;
        }

        /// <inheritdoc />
        public T? GetPublisher<T>() where T : IPublisher
        {
            if (typeof(T).IsAssignableTo(typeof(IPublisher)))
                return (T?)_publisher;

            return default;
        }

        /// <inheritdoc />
        public T? GetDomain<T>() where T : IDomain
        {
            if (typeof(T).IsAssignableTo(typeof(IDomain)))
                return (T?)_domain;

            return default;
        }

        /// <inheritdoc />
        public T? GetBusiness<T>() where T : IBusiness
        {
            if (typeof(T).IsAssignableTo(typeof(IBusiness)))
                return (T?)_business;

            return default;
        }

        /// <inheritdoc />
        public T? GetProcessor<T>() where T : IProcessor
        {
            if (typeof(T).IsAssignableTo(typeof(IProcessor)))
                return (T?)_processor;

            return default;
        }

        #endregion
    }
}
