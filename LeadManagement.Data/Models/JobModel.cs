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
        public uint Id { get; set; }

        /// <summary>
        /// Gets or sets the suburb of the job
        /// </summary>
        public SuburbModel Suburb { get; set; }

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
        public CategoryModel Category { get; set; }

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

        [ForeignKey(nameof(Suburb))]
        public uint SuburbId { get; set; }

        [ForeignKey(nameof(Category))]
        public uint CategoryId { get; set; }

        #endregion
    }
}