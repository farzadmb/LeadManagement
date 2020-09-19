using LeadManagement.Data.Models;
using LeadManagement.Domain;

namespace LeadManagement.Data.Extensions
{
    /// <summary>
    /// Extensions for <see cref="SuburbModel"/>
    /// </summary>
    public static class SuburbModelExtensions
    {
        #region Public Methods

        /// <summary>
        /// Converts <see cref="SuburbModel"/> to <see cref="Suburb"/>
        /// </summary>
        /// <param name="suburbModel">
        /// The suburb model object
        /// </param>
        /// <returns>
        /// The suburb object
        /// </returns>
        public static Suburb ToSuburb(this SuburbModel suburbModel)
        {
            return suburbModel == null ? null : new Suburb(suburbModel.Id, suburbModel.Name, suburbModel.PostCode);
        }

        #endregion
    }
}