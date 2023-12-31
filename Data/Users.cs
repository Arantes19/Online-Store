using BusinessObjects;
using Exceptions;
using System.Runtime.Serialization.Formatters.Binary;
using static Exceptions.FileExceptions;
using static Exceptions.UsersExceptions;

namespace Data
{
    /// <summary>
    /// Represents a collection of users.
    /// </summary>
    public class Users
    {
        #region Attributes

        private static List<User> listUsers;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes static members of the <see cref="Users"/> class.
        /// </summary>
        static Users()
        {
            listUsers = new List<User>
            {
                new User("admin", "admin1")
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Users"/> class.
        /// </summary>
        public Users()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of users.
        /// </summary>
        public List<User> UsersList { get { return listUsers.ToList(); } }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Retrieves a list of all users.
        /// </summary>
        /// <returns>A copy of the list of all users.</returns>
        public static List<User> GetAllUsers()
        {
            return new List<User>(listUsers);
        }

        /// <summary>
        /// Checks if a user with the specified email exists.
        /// </summary>
        /// <param name="email">The email to check.</param>
        /// <returns>True if the user exists; otherwise, false.</returns>
        public static bool ExistUser(string email)
        {
            foreach (User existingUser in listUsers)
            {
                if (existingUser.Email == email)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Inserts a new user into the list.
        /// </summary>
        /// <param name="u">The user to insert.</param>
        /// <returns>True if the user is inserted successfully; otherwise, an exception is thrown.</returns>
        /// <exception cref="Exception">Thrown if the user already exists.</exception>
        public static bool InsertUser(User u)
        {
            foreach (User existingUser in listUsers)
            {
                if (existingUser.Equals(u)) throw new UserAlreadyExistException("User Already Exists");
            }
            listUsers.Add(u);
            listUsers.Sort();
            return true;
        }

        /// <summary>
        /// Updates the password of a user.
        /// </summary>
        /// <param name="u">The user to update.</param>
        /// <param name="pass">The new password.</param>
        /// <returns>True if the password is updated successfully; otherwise, an exception is thrown.</returns>
        /// <exception cref="Exception">Thrown if the user is not found.</exception>
        public static bool UpdateUserPassword(User u, string pass)
        {
            foreach (User existingUser in listUsers)
            {
                if (existingUser.Equals(u))
                {
                    existingUser.Password = pass;
                    return true;
                }
            }
            throw new UserNotFoundException("User Not Found");
        }

        /// <summary>
        /// Updates the email of a user.
        /// </summary>
        /// <param name="u">The user to update.</param>
        /// <param name="email">The new email.</param>
        /// <returns>True if the email is updated successfully; otherwise, an exception is thrown.</returns>
        /// <exception cref="Exception">Thrown if the user is not found.</exception>
        public static bool UpdateUserEmail(User u, string email)
        {
            foreach (User existingUser in listUsers)
            {
                if (existingUser.Equals(u))
                {
                    existingUser.Email = email;
                    return true;
                }
            }
            throw new UserNotFoundException("User Not Found");
        }

        /// <summary>
        /// Deletes all users.
        /// </summary>
        /// <returns>True if all users are deleted successfully.</returns>
        public static bool DeleteAllUsers()
        {
            listUsers.Clear();
            return true;
        }

        /// <summary>
        /// Deletes a specific user.
        /// </summary>
        /// <param name="u">The user to delete.</param>
        /// <returns>True if the user is deleted successfully.</returns>
        public static bool DeleteUser(User u)
        {
            if (listUsers.Remove(u)) return true;
            return false;
        }

        /// <summary>
        /// Gets the number of users.
        /// </summary>
        /// <returns>The number of users.</returns>
        public static int NumUsers()
        {
            return listUsers.Count;
        }

        /// <summary>
        /// Reads users from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if the read operation is successful.</returns>
        /// <exception cref="Exception">Thrown if there is an error during the read operation.</exception>
        public static bool ReadUsersFile(string filename)
        {
            try
            {
                if (!File.Exists(filename)) return false;
                Stream stream;
                using (stream = File.Open(filename, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listUsers);
                    stream.Close();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw new ReadFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }

        /// <summary>
        /// Saves users to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the save operation is successful.</returns>
        /// <exception cref="Exception">Thrown if there is an error during the save operation.</exception>
        public static bool SaveUsersFile(string filename)
        {
            try
            {
                string fullPath = Path.Combine("C:\\Users\\arant\\Desktop\\LESI\\2-1\\POO\\3.1\\TrabalhoPOO_23504_FaseInt\\Database", filename);
                using (Stream stream = File.Open(fullPath, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listUsers);
                    stream.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new SaveFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }

        /// <summary>
        /// Checks if the email is valid for all users.
        /// </summary>
        /// <returns>True if the email is valid for all users; otherwise, false.</returns>
        public static bool IsEmailValid()
        {
            foreach (User existingUser in listUsers)
            {
                if (existingUser.Email is null || !existingUser.Email.Contains("@"))
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #endregion
    }
}
