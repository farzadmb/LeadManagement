namespace LeadManagement.Domain
{
    /// <summary>
    /// The contact
    /// </summary>
    public class Contact
    {
        #region Properties

        /// <summary>
        /// Gets the name of the contact
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the name of the contact
        /// </summary>
        public string Phone { get; private set; }

        /// <summary>
        /// Gets the name of the contact
        /// </summary>
        public string Email { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="name">
        /// The name of the contact
        /// </param>
        /// <param name="phone">
        /// The phone of the contact
        /// </param>
        /// <param name="email">
        /// The email of the contact
        /// </param>
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        #endregion
    }
}