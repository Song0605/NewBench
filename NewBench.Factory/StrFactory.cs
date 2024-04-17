using NewBench.Core.Interface.Ability;
using NewBench.Core.Interface.Instance;

namespace NewBench.Core
{
    /// <summary>
    /// 提供各类对象初始化的标准流程
    /// </summary>
    public static class StrFactory
    {
        public static string CreateStr(string type)
        {
            return type switch
            {
                "str1" => "1111",
                "str2" => "2222",
                _ => ""
            };
        }
    }
}
