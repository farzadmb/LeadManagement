using System.Collections.Generic;
using System.Threading.Tasks;
using LeadManagement.Data.Extensions;
using LeadManagement.Domain;

namespace LeadManagement.Data.DbHandlers
{
    /// <summary>
    /// Implementation for <see cref="IJobDbHandler"/>
    /// </summary>
    public class JobDbHandler : IJobDbHandler
    {
        #region Fields

        private readonly LeadDbContext leadDbContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDbHandler"/> class.
        /// </summary>
        /// <param name="leadDbContext">
        /// The database context
        /// </param>
        public JobDbHandler(LeadDbContext leadDbContext)
        {
            this.leadDbContext = leadDbContext;
        }

        #endregion

        #region Public Methods

        public async Task<IEnumerable<Job>> GetAllJobs()
        {
            var jobs = this.leadDbContext.JobModels;
            var suburbs = this.leadDbContext.SuburbModels;
            var categories = this.leadDbContext.CategoryModels;

            return await Task.FromResult(jobs.ToJob(suburbs, categories));
        }

        #endregion
    }
}