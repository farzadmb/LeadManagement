namespace LeadManagement.Application.DTOs
{
    /// <summary>
    /// The suburb
    /// </summary>
    public class SuburbDto
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id of the suburb
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the suburb
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the post code of the suburb
        /// </summary>
        public string PostCode { get; set; }

        #endregion
    }
}