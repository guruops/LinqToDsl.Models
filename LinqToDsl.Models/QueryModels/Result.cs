using System;

namespace LinqToDsl.Models.QueryModels
{
    [Serializable]
    public class Result : QueryBase
    {
        public dynamic Output { get; set; }
    }

    [Serializable]
    public class Result<T> : QueryBase
    {
        public T Output { get; set; }
    }
}