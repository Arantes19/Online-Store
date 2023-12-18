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
        private float balance;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the User class with default values.
        /// </summary>
        public User() 
        {
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.Balance = 0.0f;
        }

        /// <summary>
        /// Initializes a new instance of the User class with specified email and password.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password for the user's account.</param>
        public User(string email, string password, float balance)
        {
            this.Email = email;
            this.Password = password;
            this.Balance = balance;
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

        /// <summary>
        /// 
        /// </summary>
        public float Balance
        {
            get { return balance; }
            set => balance = value; 
        }

        #endregion

        #region Operadores

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

        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string UserFile()
        {
            return string.Format("|Email: {1} | Password: {2} | Saldo: {3}|", email, password, balance);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int CompareTo(User u)
        {
            if (u is null) return 1;
            if (email == u.email) return -1;
            else if (email != u.email) return 0;
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
