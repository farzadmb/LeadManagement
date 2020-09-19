using System.Collections.Generic;
using System.Threading.Tasks;
using LeadManagement.Application.DTOs;

namespace LeadManagement.Application
{
    /// <summary>
    /// The services for job
    /// </summary>
    public interface IJobServices
    {
        /// <summary>
        /// Returns all the jobs
        /// </summary>
        /// <returns>
        /// The list of jobs
        /// </returns>
        Task<IEnumerable<JobDto>> GetJobs();
    }
}