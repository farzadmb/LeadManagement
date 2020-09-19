using System.ComponentModel.DataAnnotations.Schema;

namespace LeadManagement.Data.Models
{
    /// <summary>
    /// The model for category
    /// </summary>
    public class CategoryModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id of the suburb
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the suburb
        /// </summary>
        public string Name { get; set; }

        #endregion
    }
}