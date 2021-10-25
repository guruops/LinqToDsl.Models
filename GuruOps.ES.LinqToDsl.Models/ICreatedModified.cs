using System;

namespace GuruOps.ES.LinqToDsl.Models
{
    public interface ICreatedModified : IBaseModel
    {
        DateTime Created { get; set; }

        /// <summary>
        /// Id of the user that created the record
        /// </summary>
        string CreatedById { get; set; }

        DateTime Modified { get; set; }

        /// <summary>
        /// Id of the user that modified the record
        /// </summary>
        string ModifiedById { get; set; }
    }
}
