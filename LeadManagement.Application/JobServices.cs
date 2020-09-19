using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeadManagement.Application.DTOs;
using LeadManagement.Application.Extensions;
using LeadManagement.Data.DbHandlers;

namespace LeadManagement.Application
{
    public class JobServices : IJobServices
    {
        #region Fields

        private readonly IJobDbHandler jobDbHandler;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="JobServices"/> class.
        /// </summary>
        /// <param name="jobDbHandler">
        /// the job database handler
        /// </param>
        public JobServices(IJobDbHandler jobDbHandler)
        {
            this.jobDbHandler = jobDbHandler;
        }

        #endregion

        #region Public Methods

        public async Task<IEnumerable<JobDto>> GetJobs()
        {
            var jobs = await this.jobDbHandler.GetAllJobs();
            return jobs.ToJobDto();
        }

        #endregion
    }
}
