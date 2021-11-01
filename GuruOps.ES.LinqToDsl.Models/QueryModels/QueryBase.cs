using System;

namespace GuruOps.ES.LinqToDsl.Models.QueryModels
{
    [Serializable]
    public class QueryBase
    {
        public string ContinuationToken { get; set; }
        public int? Count { get; set; }
        public Exception Exception { get; set; }
        public virtual bool IsError => Exception != null;
        public double RequestCharge { get; set; }
        public dynamic CustomOutput { get; set; }
    }
}