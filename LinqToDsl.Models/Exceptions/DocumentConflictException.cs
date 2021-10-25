using System;

namespace LinqToDsl.Models.Exceptions
{
    [Serializable]
    public class DocumentConflictException : Exception
    {
        public DocumentConflictException() : base("Record with specified id or name already exists.")
        {
        }

        public DocumentConflictException(string message) : base(message) { }
    }
}