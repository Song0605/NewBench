namespace NewBench.Core.Hub
{
    /// <summary>
    /// 保存各类Command信息
    /// </summary>
    public static class CommandHub
    {
        public static Dictionary<string, Action> CommandDict { get; set; } = new();
        static CommandHub() { }
        public static bool RegisterCommand(string key, Action action)
        {
            if (CommandDict.ContainsKey(key))
                CommandDict[key] = action;
            else
                CommandDict.Add(key, action);

            return true;
        }
        public static bool GetCommand(string key, out Action? action)
        {
            if (CommandDict.TryGetValue(key, out action))
                return true;

            return false;
        }
    }
}
