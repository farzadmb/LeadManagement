using System.Collections.Generic;
using System.Linq;
using LeadManagement.Application.DTOs;
using LeadManagement.Domain;

namespace LeadManagement.Application.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Category"/>
    /// </summary>
    public static class CategoryExtensions
    {
        #region Public Methods

        /// <summary>
        /// Converts <see cref="Category"/> to <see cref="CategoryDto"/>
        /// </summary>
        /// <param name="category">
        /// The category object
        /// </param>
        /// <returns>
        /// The category DTO object
        /// </returns>
        public static CategoryDto ToCategoryDto(this Category category)
        {
            return category == null ? null : new CategoryDto() { Id = category.Id, Name = category.Name };
        }

        #endregion
    }
}