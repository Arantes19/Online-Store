/*
*	<copyright file="IAdmins" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/


using BusinessObjects;

namespace Interfaces
{
    /// <summary>
    /// Interface for managing administrators.
    /// </summary>
    internal interface IAdmins
    {
        /// <summary>
        /// Authenticates an administrator.
        /// </summary>
        /// <param name="email">The email of the administrator.</param>
        /// <param name="password">The password of the administrator.</param>
        /// <param name="key">The authentication key.</param>
        /// <returns>True if authentication is successful; otherwise, false.</returns>
        bool AuthenticateAdmin(string email, string password, int key);

        /// <summary>
        /// Retrieves a list of all administrators.
        /// </summary>
        /// <returns>List of administrators.</returns>
        List<Admin> GetAllAdmins();

        /// <summary>
        /// Checks if an administrator with the specified email and key exists.
        /// </summary>
        /// <param name="email">The email of the administrator.</param>
        /// <param name="key">The key of the administrator.</param>
        /// <returns>True if the administrator exists; otherwise, false.</returns>
        bool ExistAdmin(string email, int key);

        /// <summary>
        /// Inserts a new administrator.
        /// </summary>
        /// <param name="a">The administrator to insert.</param>
        /// <returns>True if insertion is successful; otherwise, false.</returns>
        bool InsertAdmin(Admin a);

        /// <summary>
        /// Updates the credentials of an administrator.
        /// </summary>
        /// <param name="a">The administrator to update.</param>
        /// <param name="name">The new name of the administrator.</param>
        /// <param name="email">The new email of the administrator.</param>
        /// <param name="pass">The new password of the administrator.</param>
        /// <returns>True if the update is successful; otherwise, false.</returns>
        bool UpdateAdminCredentials(Admin a, string name, string email, string pass);

        /// <summary>
        /// Deletes all administrators.
        /// </summary>
        /// <returns>True if deletion is successful; otherwise, false.</returns>
        bool DeleteAllAdmins();

        /// <summary>
        /// Deletes a specific administrator.
        /// </summary>
        /// <param name="a">The administrator to delete.</param>
        /// <returns>True if deletion is successful; otherwise, false.</returns>
        bool DeleteAdmin(Admin a);

        /// <summary>
        /// Gets the number of administrators.
        /// </summary>
        /// <returns>The number of administrators.</returns>
        int NumAdmins();

        /// <summary>
        /// Reads administrators from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read.</param>
        /// <returns>True if reading is successful; otherwise, false.</returns>
        bool ReadAdminsFile(string filename);

        /// <summary>
        /// Saves administrators to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if saving is successful; otherwise, false.</returns>
        bool SaveAdminsFile(string filename);
    }
}
