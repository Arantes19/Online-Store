/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.User
{
    /// <summary>
    /// Represents a collection of users.
    /// </summary>
    public class Users
    {
        #region Attributes

        const int MAXUSERS = 105;
        User[] users;
        private int numUsers;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Users class.
        /// </summary>
        public Users()
        {
            users = new User[MAXUSERS];
            InitializeArrayUsers(users);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets an array containing all users in the collection.
        /// </summary>
        public User[] AllUsers
        {
            get { return users; }
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Initializes the user array by creating new User objects.
        /// </summary>
        /// <param name="users">The array to be initialized.</param>
        void InitializeArrayUsers(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new User();
            }
        }

        /// <summary>
        /// Adds a user to the collection if it doesn't already exist and the maximum limit is not reached.
        /// </summary>
        /// <param name="user">The user to be added.</param>
        /// <returns>True if the user is added successfully, false otherwise.</returns>
        public bool AddUser(User user)
        {
            foreach (User u in users)
            {
                if (u.Equals(user) || (numUsers >= MAXUSERS))
                    return false;
                else continue;
            }
            users[numUsers] = user;
            numUsers++;
            return true;
        }

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
        #endregion

        #endregion
    }
}