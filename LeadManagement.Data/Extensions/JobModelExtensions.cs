using System;
using System.Collections.Generic;
using System.Linq;
using LeadManagement.Data.Models;
using LeadManagement.Domain;
using LeadManagement.Domain.Enumerations;

namespace LeadManagement.Data.Extensions
{
    /// <summary>
    /// Profile creator for <see cref="JobModel"/>
    /// </summary>
    public static class JobModelExtensions
    {
        #region Public Methods

        /// <summary>
        /// Converts <see cref="JobModel"/> to <see cref="Job"/>
        /// </summary>
        /// <param name="jobModel">
        /// The job model object
        /// </param>
        /// <returns>
        /// The job object
        /// </returns>
        public static Job ToJob(this JobModel jobModel)
        {
            var contact = new Contact(jobModel.ContactName, jobModel.ContactPhone, jobModel.ContactEmail);
            var jobStatus = Enum.TryParse<Status>(jobModel.Status, out var status) ? status : Status.New;

            return new Job(
                jobModel.Id,
                jobModel.SuburbModel.ToSuburb(),
                contact,
                jobModel.CategoryModel.ToCategory(),
                jobModel.Description,
                jobModel.Time,
                jobModel.Price,
                jobStatus);
        }

        /// <summary>
        /// Converts a list of <see cref="JobModel"/> to a list of <see cref="Job"/>
        /// </summary>
        /// <param name="jobModels">
        /// The job model objects
        /// </param>
        /// <returns>
        /// The job objects
        /// </returns>
        public static IEnumerable<Job> ToJob(this IEnumerable<JobModel> jobModels)
        {
            return jobModels.Select(jm => jm.ToJob());
        }

        #endregion
    }
}