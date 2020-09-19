using LeadManagement.Data.Models;
using LeadManagement.Domain;

namespace LeadManagement.Data.Extensions
{
    public static class CategoryModelExtensions
    {
        #region Public Methods

        /// <summary>
        /// Converts <see cref="CategoryModel"/> to <see cref="Category"/>
        /// </summary>
        /// <param name="categoryModel">
        /// The category model object
        /// </param>
        /// <returns>
        /// The category object
        /// </returns>
        public static Category ToCategory(this CategoryModel categoryModel)
        {
            return categoryModel == null ? null : new Category(categoryModel.Id, categoryModel.Name);
        }

        #endregion
    }
}