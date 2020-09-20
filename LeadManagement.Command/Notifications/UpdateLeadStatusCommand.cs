using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LeadManagement.Command.Notifications
{
    /// <summary>
    /// The notification to update the status of a job
    /// </summary>
    public class UpdateLeadStatusCommand : IRequest<UpdateLeadStatusResponse>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id of the job
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Gets or sets the status of the job
        /// </summary>
        [Range(0, 2, ErrorMessage = "Invalid status for job")]
        public uint Status { get; set; }

        #endregion
    }
}