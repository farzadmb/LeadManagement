using System;

namespace LeadManagement.Data.Exceptions
{
    /// <summary>
    /// Exception for invalid job Id
    /// </summary>
    public class InvalidJobIdException : Exception
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidJobIdException"/> class. 
        /// </summary>
        /// <param name="id">
        /// The Id of the job
        /// </param>
        public InvalidJobIdException(uint id)
            : base($"Job with Id {id} is not found")
        {
        }

        #endregion
    }
}