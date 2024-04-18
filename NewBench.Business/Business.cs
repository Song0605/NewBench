using NewBench.Base.Interface.Ability;
using NewBench.Base.Interface.Instance;
using NewBench.Base;

namespace NewBench.Business
{
    /// <summary>
    /// 提供复杂逻辑，可以与Processor交互，获取并整理数据
    /// </summary>
    public class Business : IBusiness,
                            ISupportInstanceContainer
    {
        private IInstanceContainer? _instanceContainer;
        private IProcessor? _processor;

        public Business() { }

        /// <inheritdoc />
        public string GetStr1()
        {
            _processor ??= _instanceContainer?.GetProcessor<IProcessor>();
            if (_processor == null) return "";

            return _processor.Get("str1");
        }

        /// <inheritdoc />
        public string GetStr2()
        {
            _processor ??= _instanceContainer?.GetProcessor<IProcessor>();
            if (_processor == null) return "";

            return _processor.Get("str2");
        }

        /// <inheritdoc />
        public void UsingModel(IDomain domain, string str1, string str2)
        {
            //var model = new Model();
            //model.GetCombineStr(domain, str1, str2);
        }

        /// <inheritdoc />
        public bool Register(IInstanceContainer instanceContainer)
        {
            _instanceContainer = instanceContainer;

            return _instanceContainer != null;
        }
    }
}
