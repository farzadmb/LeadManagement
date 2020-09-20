using System;
using LeadManagement.Domain.Enumerations;

namespace LeadManagement.Domain
{
    public class Job
    {
        #region Properties

        /// <summary>
        /// Gets the Id of the job
        /// </summary>
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the suburb of the job
        /// </summary>
        public Suburb Suburb { get; private set; }

        public Contact Contact { get; private set; }

        /// <summary>
        /// Gets the category of the job
        /// </summary>
        public Category Category { get; private set; }

        /// <summary>
        /// Gets the description of the job
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the time of the job
        /// </summary>
        public DateTime Time { get; private set; }

        /// <summary>
        /// Gets the price of the job
        /// </summary>
        public uint Price { get; private set; }

        /// <summary>
        /// Gets the status of the job
        /// </summary>
        public Status Status { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Job"/> class. 
        /// </summary>
        /// <param name="id">
        /// The Id
        /// </param>
        /// <param name="suburb">
        /// The suburb
        /// </param>
        /// <param name="contact">
        /// The contact.
        /// </param>
        /// <param name="category">
        /// The category
        /// </param>
        /// <param name="description">
        /// The description
        /// </param>
        /// <param name="time">
        /// The time of the job
        /// </param>
        /// <param name="price">
        /// The price of the job
        /// </param>
        /// <param name="status">
        /// The status of the job
        /// </param>
        public Job(
            uint id,
            Suburb suburb,
            Contact contact,
            Category category,
            string description,
            DateTime time,
            uint price,
            Status status)
        {
            Id = id;
            Suburb = suburb;
            Contact = contact;
            Category = category;
            Description = description;
            Time = time;
            Price = price;
            Status = status;
        }

        #endregion

        #region Actions

        public void UpdateStatus(Status status)
        {
            System.Diagnostics.Debug.WriteLine($"Status {status}");
            Status = status;
        }

        #endregion
    }
}