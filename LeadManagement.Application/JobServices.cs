using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using LeadManagement.Application.DTOs;
using LeadManagement.Data.DbHandlers;

namespace LeadManagement.Application
{
    public class JobServices
    {
        #region Fields

        private readonly IJobDbHandler jobDbHandler;

        private readonly IMapper mapper;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="JobServices"/> class.
        /// </summary>
        /// <param name="jobDbHandler">
        /// the job database handler
        /// </param>
        /// <param name="mapper">
        /// The auto mapper.
        /// </param>
        public JobServices(IJobDbHandler jobDbHandler, IMapper mapper)
        {
            this.jobDbHandler = jobDbHandler;
            this.mapper = mapper;
        }

        #endregion

        #region Public Methods

        public async Task<IEnumerable<JobDto>> GetJobs()
        {
            var jobs = await this.jobDbHandler.GetAllJobs();
            return this.mapper.Map<IEnumerable<JobDto>>(jobs);
        }

        #endregion
    }
}
