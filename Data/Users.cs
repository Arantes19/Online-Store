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

        static Dictionary<int, List<User>> users;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public Users() { }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static bool InsereUtente(User u, int ano)
        {
            if (!users.ContainsKey(ano))
                users.Add(ano, new List<User>());
            if (!users[ano].Contains(u))
            {
                users[ano].Add(u);
                return true;
            }
            return false;
        }

        /*
        /// <summary>
        /// Deletes all users in the collection by creating new User objects.
        /// </summary>
        /// <returns>True if deletion is successful, false otherwise.</returns>
        public bool DeleteAllUsers()
        {
        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] is null) continue;
            else users[i] = new User();
        }
        return true;
        }

         /// <summary>
        /// Deletes a specific user from the collection.
        /// </summary>
        /// <param name="u">The user to be deleted.</param>
        /// <returns>True if the user is deleted successfully, false otherwise.</returns>
        public bool DeleteUser(User u)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Equals(u))
                {
                    for (int j = i; j < users.Length; j++)
                    users[j] = users[j + i];
                users[users.Length - 1] = new User();
                return true;
                }
            }
            return false;
        }
        */
        #endregion

        #endregion
    }
}
