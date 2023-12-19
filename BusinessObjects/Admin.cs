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
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="key"></param>
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
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator ==(Admin a, Admin b)
        {
            if (a.adminKey == b.adminKey)
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator !=(Admin a, Admin b)
        {
            return (!(a == b));
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
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int CompareTo(Admin a)
        {
            if (a is null) return 1;
            else return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion
    }
}