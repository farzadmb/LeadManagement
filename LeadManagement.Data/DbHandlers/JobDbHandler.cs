using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeadManagement.Data.Extensions;
using LeadManagement.Domain;
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

        #endregion
    }
}