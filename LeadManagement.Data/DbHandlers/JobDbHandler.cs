using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LeadManagement.Data.Exceptions;
using LeadManagement.Data.Extensions;
using LeadManagement.Domain;
using LeadManagement.Domain.Enumerations;

using Microsoft.EntityFrameworkCore;

namespace LeadManagement.Data.DbHandlers
{
    /// <summary>
    /// Implementation for <see cref="IJobDbHandler"/>
    /// </summary>
    public class JobDbHandler : IJobDbHandler
    {
        #region Fields

        private readonly SqLiteDbContext leadDbContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDbHandler"/> class.
        /// </summary>
        /// <param name="leadDbContext">
        /// The database context
        /// </param>
        public JobDbHandler(SqLiteDbContext leadDbContext)
        {
            this.leadDbContext = leadDbContext;
        }

        #endregion

        #region Public Methods

        public async Task<IEnumerable<Job>> GetAllJobs()
        {
            var jobs = this.leadDbContext.JobModels.Include("Category").Include("Suburb").ToList();

            return await Task.FromResult(jobs.ToJob());
        }

        public async Task<Job> GetJobById(uint jobId)
        {
            var job = this.leadDbContext.JobModels.FirstOrDefault(j => j.Id == jobId);

            return await Task.FromResult(job.ToJob());
        }

        public async Task UpdateJobAsync(Job job)
        {
            var jobModel = this.leadDbContext.JobModels.FirstOrDefault(j => j.Id == job.Id);

            if (jobModel == null)
            {
                throw new InvalidJobIdException(job.Id);
            }

            // TODO: Add other properties to update
            jobModel.Status = job.Status.ToString().ToUpper();

            await this.leadDbContext.SaveChangesAsync();
        }

        #endregion
    }
}