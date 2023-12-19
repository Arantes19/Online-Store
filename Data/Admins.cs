/*
*	<copyright file="Admins" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using BusinessObjects;
using System.Runtime.Serialization.Formatters.Binary;

namespace Data
{
    /// <summary>
    /// Represents a collection of administrators.
    /// </summary>
    public class Admins
    {
        #region Attributes

        private static List<Admin> listAdmins;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Admins"/> class.
        /// </summary>
        static Admins()
        {
            listAdmins = new List<Admin>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Admins"/> class.
        /// The default Constructor.
        /// </summary>
        public Admins()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of administrators.
        /// </summary>
        public List<Admin> AdminsList { get { return listAdmins.ToList(); } }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Authenticates an administrator based on email, password, and key.
        /// </summary>
        /// <param name="email">The email of the administrator.</param>
        /// <param name="password">The password of the administrator.</param>
        /// <param name="key">The key of the administrator.</param>
        /// <returns>True if authentication is successful; otherwise, false.</returns>
        public static bool AuthenticateAdmin(string email, string password, int key)
        {
            foreach (Admin admin in listAdmins)
            {
                if (admin.Email == email && admin.Password == password && admin.AdminKey == key)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets a list of all administrators.
        /// </summary>
        /// <returns>A list of administrators.</returns>
        public static List<Admin> GetAllAdmins()
        {
            return new List<Admin>(listAdmins);
        }

        /// <summary>
        /// Checks if an administrator with the given email and key exists.
        /// </summary>
        /// <param name="email">The email to check.</param>
        /// <param name="key">The key to check.</param>
        /// <returns>True if an administrator with the given email and key exists; otherwise, false.</returns>
        public static bool ExistAdmin(string email, int key)
        {
            foreach (Admin existingAdm in listAdmins)
            {
                if (existingAdm.Email == email && existingAdm.AdminKey == key)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Inserts a new administrator.
        /// </summary>
        /// <param name="a">The administrator to insert.</param>
        /// <returns>True if the administrator is inserted successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during insertion.</exception>
        public static bool InsertAdmin(Admin a)
        {
            foreach (Admin existingAdmin in listAdmins)
            {
                if (existingAdmin.Equals(a)) throw new Exception();
            }
            listAdmins.Add(a);
            listAdmins.Sort();
            return true;
        }

        /// <summary>
        /// Updates the credentials of an administrator.
        /// </summary>
        /// <param name="a">The administrator to update.</param>
        /// <param name="name">The new username.</param>
        /// <param name="email">The new email.</param>
        /// <param name="pass">The new password.</param>
        /// <returns>True if the credentials are updated successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during the update.</exception>
        public static bool UpdateAdminCredentials(Admin a, string name, string email, string pass)
        {
            foreach (Admin existingAdmin in listAdmins)
            {
                if (existingAdmin.Equals(a))
                {
                    existingAdmin.AdminUsername = name;
                    existingAdmin.Email = email;
                    existingAdmin.Password = pass;
                    return true;
                }
            }
            throw new Exception();
        }

        /// <summary>
        /// Deletes all administrators.
        /// </summary>
        /// <returns>True if all administrators are deleted successfully; otherwise, false.</returns>
        public static bool DeleteAllAdmins()
        {
            listAdmins.Clear();
            return true;
        }

        /// <summary>
        /// Deletes an administrator.
        /// </summary>
        /// <param name="a">The administrator to delete.</param>
        /// <returns>True if the administrator is deleted successfully; otherwise, false.</returns>
        public static bool DeleteAdmin(Admin a)
        {
            if (listAdmins.Remove(a)) return true;
            return false;
        }

        /// <summary>
        /// Gets the number of administrators.
        /// </summary>
        /// <returns>The number of administrators.</returns>
        public static int NumAdmins()
        {
            return listAdmins.Count;
        }

        /// <summary>
        /// Reads administrators from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if administrators are read successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during reading.</exception>
        public static bool ReadAdminsFile(string filename)
        {
            try
            {
                if (!File.Exists(filename)) return false;
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listAdmins);
                    stream.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Saves administrators to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if administrators are saved successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during saving.</exception>
        public static bool SaveAdminsFile(string filename)
        {
            try
            {
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listAdmins);
                    stream.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        #endregion

        #endregion
    }
}
