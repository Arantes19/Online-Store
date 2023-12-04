using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class User
    {
        #region Attributes

        public string email;
        public string password;
        //private bool isAdmin;
        //private bool isEmailConfirmed;
        //private bool isCostumer;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the User class with default values.
        /// </summary>
        public User() { }

        /// <summary>
        /// Initializes a new instance of the User class with specified email and password.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password for the user's account.</param>
        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        public string Email
        {
            set => email = value;
            get { return email; }
        }

        /// <summary>
        /// Gets or sets the password associated with the user's account.
        /// </summary>
        public string Password
        {
            get { return password; }
            set => password = value;
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #endregion
    }
}
