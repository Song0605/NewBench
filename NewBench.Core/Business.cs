namespace NewBench.Core
{
    /// <summary>
    /// 提供复杂逻辑，可以与Processor交互，获取并整理数据
    /// </summary>
    public class Business
    {
        private readonly Instance _instance;

        public Business(Instance instance)
        {
            _instance = instance;
        }

        public string GetStr1()
        {
            var processor = _instance.GetProcessor<Processor>();
            if (processor == null) return "";

            return processor.Get("str1");
        }
        public string GetStr2()
        {
            var processor = _instance.GetProcessor<Processor>();
            if (processor == null) return "";

            return processor.Get("str2");
        }

        public void UsingModel(Domain domain, string str1, string str2)
        {
            var model = new Model();
            model.GetCombineStr(domain, str1, str2);
        }
    }
}
