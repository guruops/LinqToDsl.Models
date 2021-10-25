using System;
using System.Collections.Generic;
using System.Linq;

namespace GuruOps.ES.LinqToDsl.Models.Exceptions
{
    [Serializable]
    public class ForbidActionException : Exception
    {
        public ForbidActionException() : base("Not allowed action for this record.")
        {
        }

        public ForbidActionException(List<string> messages) : this(messages?.ToArray())
        {
        }

        public ForbidActionException(params string[] messages)
            : base(string.Join(",", (messages?.ToList() ?? new List<string>()).Where(c => !string.IsNullOrWhiteSpace(c)).ToArray()))
        {
        }
    }
}
