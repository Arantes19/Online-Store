using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
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
        ///
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (User a, User b)
        {
            if(a.email == b.email) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator != (User a, User b)
        {
            return !(a == b);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return UserFile();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj is User)
            {
                User u = (User)obj;
                if (this == u) return true;
            }
            return false;
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

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string UserFile()
        {
            return string.Format("Email: {0}, Password: {1}", email, password);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int CompareTo(User u)
        {
            if (u is null) return 1;
            else return 0;
        }

        #endregion

        #endregion
    }
}
