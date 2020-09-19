using System.Collections.Generic;
using System.Threading.Tasks;
using LeadManagement.Domain;

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
    }
}