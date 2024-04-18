namespace NewBench.Base.Base
{
    public class EventArgs<T> : EventArgs where T : class
    {
        public T Value { get; }
        public EventArgs(T value)
        {
            Value = value;
        }
    }
}
