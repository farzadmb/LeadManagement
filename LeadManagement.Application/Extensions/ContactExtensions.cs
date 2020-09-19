using System.Collections.Generic;
using System.Linq;
using LeadManagement.Application.DTOs;
using LeadManagement.Domain;

namespace LeadManagement.Application.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Contact"/>
    /// </summary>
    public static class ContactExtensions
    {
        #region Public Methods

        /// <summary>
        /// Converts a <see cref="Contact"/> to a <see cref="ContactDto"/>
        /// </summary>
        /// <param name="contact">
        /// The contact object
        /// </param>
        /// <returns>
        /// The contact DTO object
        /// </returns>
        public static ContactDto ToContactDto(this Contact contact)
        {
            return contact == null ? null : new ContactDto() { Name = contact.Name, Phone = contact.Phone, Email = contact.Email };
        }

        #endregion
    }
}