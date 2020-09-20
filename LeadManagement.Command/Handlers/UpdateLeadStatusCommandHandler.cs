using System.Threading;
using System.Threading.Tasks;
using LeadManagement.Command.Notifications;
using LeadManagement.Data.DbHandlers;
using LeadManagement.Data.Exceptions;
using LeadManagement.Domain.Enumerations;
using MediatR;

namespace LeadManagement.Command.Handlers
{
    /// <summary>
    /// Handler for <see cref="UpdateLeadStatusCommand"/>
    /// </summary>
    public class UpdateLeadStatusCommandHandler : IRequestHandler<UpdateLeadStatusCommand, UpdateLeadStatusResponse>
    {
        #region Fields

        private readonly IJobDbHandler jobDbHandler;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLeadStatusCommandHandler"/> class.
        /// </summary>
        /// <param name="jobDbHandler">
        /// The job database handler
        /// </param>
        public UpdateLeadStatusCommandHandler(IJobDbHandler jobDbHandler)
        {
            this.jobDbHandler = jobDbHandler;
        }

        #endregion

        #region Public Methods

        public async Task<UpdateLeadStatusResponse> Handle(UpdateLeadStatusCommand request, CancellationToken cancellationToken)
        {
            var job = await this.jobDbHandler.GetJobById(request.Id);

            if (job == null)
            {
                throw new InvalidJobIdException(request.Id);
            }

            job.UpdateStatus((Status) request.Status);

            await this.jobDbHandler.UpdateJobAsync(job);

            return new UpdateLeadStatusResponse() { Id = request.Id, Status = request.Status };
        }

        #endregion
    }
}