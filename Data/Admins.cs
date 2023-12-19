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
        /// 
        /// </summary>
        static Admins()
        {
            listAdmins = new List<Admin>();
        }

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Admins()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<Admin> AdminsList { get { return listAdmins.ToList(); } }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="key"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Admin> GetAllAdmins() 
        {
            return new List<Admin>(listAdmins);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="key"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool InsertAdmin(Admin a)
        {
            foreach(Admin existingAdmin in listAdmins)
            {
                if (existingAdmin.Equals(a)) throw new Exception();
            }
            listAdmins.Add(a);
            listAdmins.Sort();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool DeleteAllAdmins()
        {
            listAdmins.Clear();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool DeleteAdmin(Admin a)
        {
            if (listAdmins.Remove(a)) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NumAdmins()
        {
            return listAdmins.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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