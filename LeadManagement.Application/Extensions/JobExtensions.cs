using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LeadManagement.Application.DTOs;
using LeadManagement.Domain;

namespace LeadManagement.Application.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Job"/>
    /// </summary>
    public static class JobExtensions
    {
        #region Public Methods

        /// <summary>
        /// Converts a <see cref="Job"/> to a <see cref="JobDto"/>
        /// </summary>
        /// <param name="job">
        /// The job object
        /// </param>
        /// <returns>
        /// The job DTO object
        /// </returns>
        public static JobDto ToJobDto(this Job job)
        {
            return new JobDto()
                       {
                           Id = job.Id,
                           Suburb = job.Suburb.ToSuburbDto(),
                           Contact = job.Contact.ToContactDto(),
                           Category = job.Category.ToCategoryDto(),
                           Description = job.Description,
                           Time = job.Time,
                           Price = job.Price,
                           Status = job.Status
                       };
        }

        /// <summary>
        /// Converts a list of <see cref="Job"/> to a list of <see cref="JobDto"/>
        /// </summary>
        /// <param name="jobs">
        /// The job objects
        /// </param>
        /// <returns>
        /// The job DTO objects
        /// </returns>
        public static IEnumerable<JobDto> ToJobDto(this IEnumerable<Job> jobs)
        {
            return jobs.Select(j => j.ToJobDto());
        }

        #endregion
    }
}
