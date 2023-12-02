/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

namespace BusinessObjects
{
    /// <summary>
    /// Represents an administrator, extending the User class.
    /// </summary>
    public class Admin : User
    {
        #region Attributes

        private string adminUsername;
        private int adminKey;
        private static int numAdmin = 0;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes static members of the Admin class.
        /// </summary>
        static Admin() => numAdmin = 0;

        /// <summary>
        /// Initializes a new instance of the Admin class with default values.
        /// </summary>
        public Admin()
        {
            email = string.Empty;
            password = string.Empty;
            adminUsername = string.Empty;
            adminKey = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Admin class with specified email, password, and key.
        /// </summary>
        /// <param name="email">The email address of the administrator.</param>
        /// <param name="password">The password for the administrator's account.</param>
        /// <param name="key">The key associated with the administrator.</param>
        public Admin(string email, string password, int key) : base(email, password)
        {
            adminKey = key;
        }

        /// <summary>
        /// Initializes a new instance of the Admin class with specified username, email, password, and key.
        /// </summary>
        /// <param name="username">The username of the administrator.</param>
        /// <param name="email">The email address of the administrator.</param>
        /// <param name="password">The password for the administrator's account.</param>
        /// <param name="key">The key associated with the administrator.</param>
        public Admin(string username, string email, string password, int key) : base(email, password)
        {
            adminUsername = username;
            adminKey = key;
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
            return string.Format("Name: {0}, Email: {1}, Password: {2}, Key: {3}", adminUsername, email, password, adminKey);
        }

        /// <summary>
        /// Checks if an administrator with the specified key already exists in the given array of administrators.
        /// </summary>
        /// <param name="admins">The array of administrators to search through.</param>
        /// <param name="key">The key to check for existence.</param>
        /// <returns>True if an administrator with the specified key exists; otherwise, false.</returns>
        public bool ExistAdmin(Admin[] admins, int key)
        {
            foreach (Admin a in admins)
                if (a.AdminKey == key) return true;
            return false;
        }

        #endregion

        #endregion
    }
}
