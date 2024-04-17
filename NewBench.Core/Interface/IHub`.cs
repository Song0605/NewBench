﻿namespace NewBench.Core.Interface
{
    public interface IHub<T> where T : class
    {
        bool Register(string key, T value);
        bool Get(string key, out T? value);
    }

}
