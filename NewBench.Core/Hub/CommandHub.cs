using NewBench.Core.Base;
using NewBench.Core.Interface;
using System;

namespace NewBench.Core.Hub
{
    /// <summary>
    /// 保存各类Command信息
    /// </summary>
    public class CommandHub : BaseHub<Action>
    {
        public CommandHub() { }

        public override bool Register(string key, Action value)
        {
            if (ValueDict.ContainsKey(key))
                ValueDict[key] = value;
            else
                ValueDict.Add(key, value);

            return true;

        }

        public override bool Get(string key, out Action? value)
        {
            if (ValueDict.TryGetValue(key, out value))
                return true;

            return false;
        }
    }
}
