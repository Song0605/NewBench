namespace NewBench.Base.Interface.Instance
{
    public interface IBusiness
    {
        string GetStr1();
        string GetStr2();
        void UsingModel(IDomain domain, string str1, string str2);
    }
}
