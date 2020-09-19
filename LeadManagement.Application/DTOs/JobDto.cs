using System;
using LeadManagement.Domain.Enumerations;

namespace LeadManagement.Application.DTOs
{
    public class JobDto
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id of the job
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Gets or sets the suburb of the job
        /// </summary>
        public SuburbDto Suburb { get; set; }

        /// <summary>
        /// Gets or sets or sets the contact
        /// </summary>
        public ContactDto Contact { get; set; }

        /// <summary>
        /// Gets or sets the category of the job
        /// </summary>
        public CategoryDto Category { get; set; }

        /// <summary>
        /// Gets or sets the description of the job
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the time of the job
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets the price of the job
        /// </summary>
        public uint Price { get; set; }

        /// <summary>
        /// Gets or sets the status of the job
        /// </summary>
        public Status Status { get; set; }

        #endregion
    }
}