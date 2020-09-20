using System.Threading.Tasks;
using LeadManagement.Application;
using LeadManagement.Command.Notifications;
using LeadManagement.Data.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeadManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        #region Fields

        private readonly IJobServices jobServices;

        private readonly IMediator mediator;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsController"/> class.
        /// </summary>
        /// <param name="jobServices">
        /// The job services
        /// </param>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        public JobsController(IJobServices jobServices, IMediator mediator)
        {
            this.jobServices = jobServices;
            this.mediator = mediator;
        }

        #endregion

        #region Get

        /// <summary>
        /// Returns all the jobs
        /// </summary>
        /// <returns>
        /// The jobs
        /// </returns>
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetJobs()
        {
            var jobs = await this.jobServices.GetJobs();
            return Ok(jobs);
        }

        #endregion

        #region Put

        /// <summary>
        /// Updates the status of the job
        /// </summary>
        /// <param name="command">
        /// The update command
        /// </param>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateStatus(UpdateLeadStatusCommand command)
        {
            try
            {
                await this.mediator.Send(command);
            }
            catch (InvalidJobIdException e)
            {
                return NotFound(e.Message);
            }

            return Ok();
        }

        #endregion
    }
}