using System.Collections.Generic;
using System.Linq;
using LeadManagement.Application.DTOs;
using LeadManagement.Domain;

namespace LeadManagement.Application.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Suburb"/>
    /// </summary>
    public static class SuburbExtensions
    {
        #region Public Methods

        /// <summary>
        /// Converts <see cref="Suburb"/> to <see cref="SuburbDto"/>
        /// </summary>
        /// <param name="suburb">
        /// The Suburb object
        /// </param>
        /// <returns>
        /// The Suburb DTO object
        /// </returns>
        public static SuburbDto ToSuburbDto(this Suburb suburb)
        {
            return suburb == null ? null : new SuburbDto() { Id = suburb.Id, Name = suburb.Name, PostCode = suburb.PostCode };
        }

        #endregion
    }
}