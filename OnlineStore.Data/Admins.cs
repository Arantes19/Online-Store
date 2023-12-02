/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

namespace OnlineStore.Data
{
    /// <summary>
    /// Represents a collection of administrators.
    /// </summary>
    public class Admins
    {
        #region Attributes

        const int MAXADMINS = 5;
        Admin[] admins;
        private int numAdmins;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Admins class.
        /// </summary>
        public Admins()
        {
            admins = new Admin[MAXADMINS];
            InitializeArrayAdmin(admins);
        }


        #endregion

        #region Properties

        /// <summary>
        /// Gets an array containing all administrators in the collection.
        /// </summary>
        public Admin[] AllAdmins
        {
            get { return admins; }
        }

        #endregion


        #region OtherMethods

        /// <summary>
        /// Initializes the administrator array by creating new Admin objects.
        /// </summary>
        /// <param name="admins">The array to be initialized.</param>
        void InitializeArrayAdmin(Admin[] admins)
        {
            for (int i = 0; i < admins.Length; i++)
            {
                admins[i] = new Admin();
            }
        }

        /// <summary>
        /// Adds an administrator to the collection if it doesn't already exist and the maximum limit is not reached.
        /// </summary>
        /// <param name="admin">The administrator to be added.</param>
        /// <returns>True if the administrator is added successfully, false otherwise.</returns>
        public bool AddAdmin(Admin admin)
        {
            foreach (Admin a in admins)
            {
                if (a.AdminKey == 0)
                    continue;
                if (a.Equals(admin) || numAdmins >= MAXADMINS)
                    return false;
            }
            admins[numAdmins] = admin;
            numAdmins++;
            return true;
        }

        /// <summary>
        /// Deletes all administrators in the collection by creating new Admin objects.
        /// </summary>
        /// <returns>True if deletion is successful, false otherwise.</returns>
        public bool DeleteAllAdmins()
        {
            for (int i = 0; i < admins.Length; i++)
            {
                if (admins[i].AdminKey is 0) continue;
                else admins[i] = new Admin();
            }
            return true;
        }

        /// <summary>
        /// Deletes a specific administrator from the collection.
        /// </summary>
        /// <param name="a">The administrator to be deleted.</param>
        /// <returns>True if the administrator is deleted successfully, false otherwise.</returns>
        public bool DeleteAdmin(Admin a)
        {
            for (int i = 0; i < admins.Length; i++)
            {
                if (admins[i].Equals(a))
                {
                    for (int j = i; j < admins.Length; j++)
                        admins[j] = admins[j + i];
                    admins[admins.Length - 1] = new Admin();
                    return true;
                }
            }
            return false;
        }

        #endregion

        #endregion
    }
}
