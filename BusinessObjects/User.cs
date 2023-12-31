/*
*	<copyright file="User" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

namespace BusinessObjects
{
    [Serializable]
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class User
    {
        #region Attributes

        private string email;
        private string password;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the User class with default values.
        /// </summary>
        public User()
        {
            this.email = string.Empty;
            this.password = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the User class with specified email and password.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password associated with the user's account.</param>
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

        #region Operators

        /// <summary>
        /// Determines whether two users are equal based on their email addresses.
        /// </summary>
        /// <param name="a">The first user.</param>
        /// <param name="b">The second user.</param>
        /// <returns>True if the users are equal; otherwise, false.</returns>
        public static bool operator ==(User a, User b)
        {
            if (a.email == b.email) return true;
            return false;
        }

        /// <summary>
        /// Determines whether two users are not equal based on their email addresses.
        /// </summary>
        /// <param name="a">The first user.</param>
        /// <param name="b">The second user.</param>
        /// <returns>True if the users are not equal; otherwise, false.</returns>
        public static bool operator !=(User a, User b)
        {
            return !(a == b);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the user's information.
        /// </summary>
        /// <returns>A string containing the user's information.</returns>
        public override string ToString()
        {
            return UserFile();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                User u = (User)obj;
                if (this == u) return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the hash code for this object.
        /// </summary>
        /// <returns>A hash code value.</returns>
        /// <exception cref="NotImplementedException">Thrown if GetHashCode is not implemented.</exception>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Retrieves a string representation of the user's information.
        /// </summary>
        /// <returns>A formatted string containing the user's information.</returns>
        public string UserFile()
        {
            return string.Format("Email: {0}, Password: {1}", email, password);
        }

        /// <summary>
        /// Compares the user to another user and returns the result.
        /// </summary>
        /// <param name="u">The user to compare with.</param>
        /// <returns>1 if the user is null; otherwise, 0.</returns>
        public int CompareTo(User u)
        {
            if (u is null) return 1;
            else return 0;
        }

        #endregion

        #endregion
    }
}
