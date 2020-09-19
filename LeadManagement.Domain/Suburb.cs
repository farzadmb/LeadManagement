namespace LeadManagement.Domain
{
    /// <summary>
    /// The Suburb
    /// </summary>
    public class Suburb
    {
        #region Properties

        /// <summary>
        /// Gets the Id of the suburb
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets the name of the suburb
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the post code of the suburb
        /// </summary>
        public string PostCode { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Suburb"/> class. 
        /// </summary>
        /// <param name="id">
        /// The Id
        /// </param>
        /// <param name="name">
        /// The name
        /// </param>
        /// <param name="postCode">
        /// The post code
        /// </param>
        public Suburb(int id, string name, string postCode)
        {
            Id = id;
            Name = name;
            PostCode = postCode;
        }

        #endregion
    }
}