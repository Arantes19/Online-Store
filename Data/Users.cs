using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Represents a collection of users.
    /// </summary>
    public class Users
    {
        #region Attributes

        List<User> users;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public Users()
        {
            users = new List<User>();
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        public User GetUserByEmail(string userEmail)
        {
            return users.FirstOrDefault(u => u.Email == userEmail);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool AddUser(User u)
        {
            if (users.Contains(u)) 
                return false;
            users.Add(u);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="updatedUser"></param>
        /// <returns></returns>
        public bool UpdateUser(User updatedUser)
        {
            var existingUser = users.FirstOrDefault(u => u.Email == updatedUser.Email);

            if (existingUser != null)
            {
                // Update user properties
                existingUser.Password = updatedUser.Password;
                // Update other properties as needed

                return true;
            }

            return false; // User not found
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        public bool DeleteUser(string userEmail)
        {
            var userToDelete = users.FirstOrDefault(u => u.Email == userEmail);

            if (userToDelete != null)
            {
                users.Remove(userToDelete);
                return true;
            }

            return false; // User not found
        }

        #endregion

        #endregion
    }
}
