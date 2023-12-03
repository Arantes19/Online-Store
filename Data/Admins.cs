using BusinessObjects;

namespace Data
{
    /// <summary>
    /// Represents a collection of administrators.
    /// </summary>
    public class Admins
    {
        #region Attributes

        static Dictionary<int, List<Admin>> admins;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Admins() { }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods

        public static bool InsereUtente(Admin a, int key)
        {
            if (!admins.ContainsKey(key))
                admins.Add(key, new List<Admin>());
            if (!admins[key].Contains(a))
            {
                admins[key].Add(a);
                return true;
            }
            return false;
        }

        /*  
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
                if (a.Equals(admin) || (numAdmins >= MAXADMINS))
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
        */

        #endregion

        #endregion
    }
}