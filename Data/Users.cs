using BusinessObjects;
using System.Runtime.Serialization.Formatters.Binary;

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
        /// 
        /// </summary>
        static Users()
        {
            listUsers = new List<User>
            {
                new User("admin", "admin1")
            };
        }

        /// <summary>
        /// 
        /// </summary>
        public Users()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<User> UsersList { get { return listUsers.ToList(); }}

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
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="email"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool InsertUser(User u)
        {
            foreach(User existingUser in listUsers)
            {
                if(existingUser.Equals(u)) throw new Exception();
            }
            listUsers.Add(u);
            listUsers.Sort();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool UpdateUserPassword(User u, string pass)
        {
            foreach(User existingUser in listUsers)
            {
                if (existingUser.Equals(u))
                {
                    existingUser.Password = pass;
                    return true;
                }
            }
            throw new Exception();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
            throw new Exception();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool DeleteAllUsers()
        {
            listUsers.Clear();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool DeleteUser(User u)
        {
            if (listUsers.Remove(u)) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NumUsers()
        {
            return listUsers.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool ReadUsersFile(string filename)
        {
            try
            {
                if (!File.Exists(filename)) return false;
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listUsers);
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
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool SaveUsersFile(string filename)
        {
            try
            {
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listUsers);
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
