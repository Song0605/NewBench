namespace NewBench.Core.Interface.Instance
{
    public interface IBusiness
    {
        string GetStr1();
        string GetStr2();
        void UsingModel(Domain domain, string str1, string str2);
    }
}
