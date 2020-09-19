using System;
using System.ComponentModel;

namespace LeadManagement.Domain
{
    public class Job
    {
        #region Properties

        public int Id { get; private set; }

        public Suburb Suburb { get; private set; }

        public Category Category { get; private set; }

        public string Description { get; private set; }

        public DateTime Time { get; private set; }

        public uint Price { get; private set; }

        public Status Status { get; private set; }

        #endregion

        #region Constructor

        public Job(int id, Suburb suburb, Category category, string description, DateTime time, uint price, Status status)
        {
            Id = id;
            Suburb = suburb;
            Category = category;
            Description = description;
            Time = time;
            Price = price;
            Status = status;
        }

        #endregion
    }
}