using NewBench.Base.Interface.Instance;

namespace NewBench.Base.Interface.Ability
{
    public interface ISupportInstanceContainer
    {
        bool Register(IInstanceContainer instanceContainer);
    }
}