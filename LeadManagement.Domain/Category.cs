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
        public int Id { get; private set; }

        /// <summary>
        /// Gets the name of the suburb
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the parent category
        /// </summary>
        public Category ParentCategory { get; private set; }

        #endregion

        #region Construction

        public Category(int id, string name, Category parentCategory)
        {
            Id = id;
            Name = name;
            ParentCategory = parentCategory;
        }

        #endregion
    }
}