using System.Collections.Generic;
using System.Threading.Tasks;
using LeadManagement.Domain;
using LeadManagement.Domain.Enumerations;

namespace LeadManagement.Data.DbHandlers
{
    /// <summary>
    /// The database handler fpr jobs
    /// </summary>
    public interface IJobDbHandler
    {
        /// <summary>
        /// Gets all the jobs
        /// </summary>
        /// <returns>
        /// The list of <see cref="Job"/>
        /// </returns>
        Task<IEnumerable<Job>> GetAllJobs();

        /// <summary>
        /// Selects job by Id
        /// </summary>
        /// <param name="jobId">
        /// The Id of the job
        /// </param>
        /// <returns>
        /// The job
        /// </returns>
        Task<Job> GetJobById(uint jobId);

        /// <summary>
        /// Updates the status of the job
        /// </summary>
        /// <param name="job">
        /// The job.
        /// </param>
        /// <returns>
        /// </returns>
        Task UpdateJobAsync(Job job);
    }
}