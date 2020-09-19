using System.Threading.Tasks;
using LeadManagement.Application;
using Microsoft.AspNetCore.Mvc;

namespace LeadManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        #region Fields

        private readonly IJobServices jobServices;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsController"/> class.
        /// </summary>
        /// <param name="jobServices">
        /// The job services
        /// </param>
        public JobsController(IJobServices jobServices)
        {
            this.jobServices = jobServices;
        }

        #endregion

        #region Get

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetJobs()
        {
            var jobs = await this.jobServices.GetJobs();
            return Ok(jobs);
        }

        #endregion
    }
}
