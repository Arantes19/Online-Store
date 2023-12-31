/*
*	<copyright file="Admin" company="IPCA">
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
    /// Represents an administrator, extending the User class.
    /// </summary>
    public class Admin : User
    {
        #region Attributes

        private string adminUsername;
        private int adminKey;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Admin class with default values.
        /// </summary>
        public Admin() : base()
        {
            this.AdminUsername = string.Empty;
            this.AdminKey = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Admin class with specified values.
        /// </summary>
        /// <param name="username">The username of the administrator.</param>
        /// <param name="email">The email address of the administrator.</param>
        /// <param name="password">The password of the administrator.</param>
        /// <param name="key">The key associated with the administrator.</param>
        public Admin(string username, string email, string password, int key) : base(email, password)
        {
            this.AdminUsername = username;
            this.AdminKey = key;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the username of the administrator.
        /// </summary>
        public string AdminUsername
        {
            set => adminUsername = value;
            get { return adminUsername; }
        }

        /// <summary>
        /// Gets or sets the key associated with the administrator.
        /// </summary>
        public int AdminKey
        {
            set
            {
                if (value < 12)
                    adminKey = value;
            }
            get { return adminKey; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Equality operator for comparing two Admin objects based on the adminKey.
        /// </summary>
        /// <param name="a">The first Admin object.</param>
        /// <param name="b">The second Admin object.</param>
        /// <returns>True if the adminKeys are equal; otherwise, false.</returns>
        public static bool operator ==(Admin a, Admin b)
        {
            if (a.adminKey == b.adminKey)
                return true;
            return false;
        }

        /// <summary>
        /// Inequality operator for comparing two Admin objects based on the adminKey.
        /// </summary>
        /// <param name="a">The first Admin object.</param>
        /// <param name="b">The second Admin object.</param>
        /// <returns>True if the adminKeys are not equal; otherwise, false.</returns>
        public static bool operator !=(Admin a, Admin b)
        {
            return !(a == b);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the administrator's information.
        /// </summary>
        /// <returns>A string containing the administrator's information.</returns>
        public override string ToString()
        {
            return AdminInfo();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Admin)
            {
                Admin a = (Admin)obj;
                if (this == a)
                    return true;
            }
            return false;
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Retrieves a string representation of the administrator's information.
        /// </summary>
        /// <returns>A formatted string containing the administrator's information.</returns>
        public string AdminInfo()
        {
            return string.Format("Name: {0}, Email: {1}, Password: {2}, Key: {3}", adminUsername, Email, Password, adminKey);
        }

        /// <summary>
        /// Compares this Admin object with another Admin object.
        /// </summary>
        /// <param name="a">The Admin object to compare.</param>
        /// <returns>0 if the objects are equal; otherwise, a non-zero value.</returns>
        public int CompareTo(Admin a)
        {
            if (a is null) return 1;
            else return 0;
        }

        /// <summary>
        /// Returns a hash code for this Admin object.
        /// </summary>
        /// <returns>A hash code value.</returns>
        /// <exception cref="NotImplementedException">Thrown if GetHashCode is not implemented.</exception>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion
    }
}
