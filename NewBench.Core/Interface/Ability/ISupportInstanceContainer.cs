using NewBench.Core.Interface.Instance;

namespace NewBench.Core.Interface.Ability
{
    public interface ISupportInstanceContainer
    {
        bool Register(IInstanceContainer instanceContainer);
    }
}