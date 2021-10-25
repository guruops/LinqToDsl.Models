using System;
using System.Collections.Generic;

namespace LinqToDsl.Models.QueryModels
{
    [Serializable]
    public class ResultList : QueryBase
    {
        public List<dynamic> Output { get; set; }
    }

    [Serializable]
    public class ResultList<T> : QueryBase
    {
        public List<T> Output { get; set; }
    }
}