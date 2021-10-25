using GuruOps.ES.LinqToDsl.Models.QueryModels;
using System.Collections.Generic;
using System.Linq;

namespace GuruOps.ES.LinqToDsl.Models
{
    public static class ResultExtensions
    {
        public static Result<T> FromResult<T>(this Result result)
        {
            return new Result<T>
            {
                ContinuationToken = result.ContinuationToken,
                Exception = result.Exception,
                Output = (T)result.Output,
                RequestCharge = result.RequestCharge
            };
        }

        public static ResultList<T> FromResult<T>(this ResultList resultList)
        {
            ResultList<T> r = new ResultList<T>
            {
                ContinuationToken = resultList.ContinuationToken,
                Exception = resultList.Exception,
                RequestCharge = resultList.RequestCharge,
            };

            //ToDo: looks smelling, Output should be initialized always
            if (resultList.Output == null || !resultList.Output.Any())
                return r;

            r.Output = new List<T>();

            foreach (dynamic o in resultList.Output)
            {
                r.Output.Add((T)o);
            }

            return r;
        }

        public static double GetRequestCharge(this QueryBase result, double defaultValue = 0)
        {
            return (result?.RequestCharge).GetValueOrDefault(defaultValue);
        }
    }
}