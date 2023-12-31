/*
*	<copyright file="IUsers" company="IPCA">
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
    /// Interface for managing user-related operations.
    /// </summary>
    public interface IUsers
    {
        /// <summary>
        /// Retrieves a list of all users.
        /// </summary>
        /// <returns>A list containing all users.</returns>
        List<User> GetAllUsers();

        /// <summary>
        /// Checks if a user with the specified email exists.
        /// </summary>
        /// <param name="email">The email of the user.</param>
        /// <returns>True if the user exists; otherwise, false.</returns>
        bool ExistUser(string email);

        /// <summary>
        /// Inserts a new user.
        /// </summary>
        /// <param name="u">The user to insert.</param>
        /// <returns>True if the user was inserted successfully; otherwise, false.</returns>
        bool InsertUser(User u);

        /// <summary>
        /// Updates the password of a user.
        /// </summary>
        /// <param name="u">The user to update.</param>
        /// <param name="pass">The new password.</param>
        /// <returns>True if the password was updated successfully; otherwise, false.</returns>
        bool UpdateUserPassword(User u, string pass);

        /// <summary>
        /// Updates the email of a user.
        /// </summary>
        /// <param name="u">The user to update.</param>
        /// <param name="email">The new email.</param>
        /// <returns>True if the email was updated successfully; otherwise, false.</returns>
        bool UpdateUserEmail(User u, string email);

        /// <summary>
        /// Deletes all users.
        /// </summary>
        /// <returns>True if all users were deleted successfully; otherwise, false.</returns>
        bool DeleteAllUsers();

        /// <summary>
        /// Deletes a specific user.
        /// </summary>
        /// <param name="u">The user to delete.</param>
        /// <returns>True if the user was deleted successfully; otherwise, false.</returns>
        bool DeleteUser(User u);

        /// <summary>
        /// Deletes a user by email.
        /// </summary>
        /// <param name="email">The email of the user to delete.</param>
        /// <returns>True if the user was deleted successfully; otherwise, false.</returns>
        bool DeleteUserEmail(string email);

        /// <summary>
        /// Gets the number of users.
        /// </summary>
        /// <returns>The number of users.</returns>
        int NumUsers();

        /// <summary>
        /// Reads user data from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        bool ReadUsersFile(string filename);

        /// <summary>
        /// Saves user data to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        bool SaveUsersFile(string filename);
    }
}
