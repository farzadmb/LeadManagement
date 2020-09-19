using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeadManagement.Data.Models
{
    /// <summary>
    /// The model for job
    /// </summary>
    public class JobModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id of the job
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the suburb of the job
        /// </summary>
        public uint SuburbId { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the phone of the contact
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or sets the email of the contact
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the category of the job
        /// </summary>
        public uint CategoryId { get; set; }

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
        public string Status { get; set; }

        #endregion
    }
}