namespace NewBench.Core
{
    /// <summary>
    /// 管理实例对象
    /// </summary>
    public class Instance
    {
        private readonly Coordinator _coordinator;
        private readonly Publisher _publisher;
        private readonly Domain _domain;
        private readonly Business _business;
        private readonly Processor _processor;

        public Instance()
        {
            _coordinator = new Coordinator(this);
            _publisher = new Publisher();
            _domain = new Domain(this);
            _business = new Business(this);
            _processor = new Processor();
        }

        public Coordinator? GetCoordinator<T>() where T : Coordinator
        {
            if (typeof(T).IsAssignableFrom(typeof(Coordinator)))
                return _coordinator;

            return default;
        }

        public Publisher? GetPublisher<T>() where T : Publisher
        {
            if (typeof(T).IsAssignableFrom(typeof(Publisher)))
                return _publisher;

            return default;
        }

        public Domain? GetDomain<T>() where T : Domain
        {
            if (typeof(T).IsAssignableFrom(typeof(Domain)))
                return _domain;

            return default;
        }

        public Business? GetBusiness<T>() where T : Business
        {
            if (typeof(T).IsAssignableFrom(typeof(Business)))
                return _business;

            return default;
        }

        public Processor? GetProcessor<T>() where T : Processor
        {
            if (typeof(T).IsAssignableFrom(typeof(Processor)))
                return _processor;

            return default;
        }
    }
}
