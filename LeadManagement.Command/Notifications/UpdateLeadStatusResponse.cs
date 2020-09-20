namespace LeadManagement.Command.Notifications
{
    /// <summary>
    /// The response for updating the status of job
    /// </summary>
    public class UpdateLeadStatusResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id of the job
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Gets or sets the status of the job
        /// </summary>
        public uint Status { get; set; }

        #endregion
    }
}
