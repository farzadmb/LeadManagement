namespace LeadManagement.Domain
{
    /// <summary>
    /// The category of the job
    /// </summary>
    public class Category
    {
        #region Properties

        /// <summary>
        /// Gets the Id of the suburb
        /// </summary>
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the name of the suburb
        /// </summary>
        public string Name { get; private set; }

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="id">
        /// The Id of category
        /// </param>
        /// <param name="name">
        /// The name of category
        /// </param>
        public Category(uint id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion
    }
}