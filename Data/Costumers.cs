using BusinessObjects;
using System.Runtime.Serialization.Formatters.Binary;

namespace Data
{
    /// <summary>
    /// Represents a collection of customers.
    /// </summary>
    public class Costumers
    {
        #region Attributes

        private static List<Costumer> listCostumers;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static Costumers() 
        {
            listCostumers = new List<Costumer>();
        }

        /// <summary>
        /// 
        /// </summary>
        public Costumers()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<Costumer> CostumersList { get { return listCostumers.ToList(); } }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Authenticates a customer based on the provided credentials.
        /// </summary>
        /// <param name="email">The email address of the customer.</param>
        /// <param name="password">The password of the customer.</param>
        /// <returns>True if authentication is successful; otherwise, false.</returns>
        public static bool AuthenticateCostumer(string email, string password)
        {
            foreach (Costumer costumer in listCostumers)
            {
                if (costumer.Email == email && costumer.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Retrieves a list of all customers.
        /// </summary>
        /// <returns>A copy of the list of all customers.</returns>
        public static List<Costumer> GetAllCustomers()
        {
            return new List<Costumer>(listCostumers);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nif"></param>
        /// <returns></returns>
        public static bool ExistCostumer(int nif)
        {
            foreach(Costumer existingCostumer in listCostumers)
            {
                if(existingCostumer.Nif == nif) return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool InsertCostumer(Costumer c)
        {
            foreach (Costumer existingCostumer in listCostumers)
            {
                if (existingCostumer.Equals(c)) throw new Exception();
            }
            listCostumers.Add(c);
            listCostumers.Sort();
            return true;
        }

        /// <summary>
        /// Adds balance to the customer's account.
        /// </summary>
        /// <param name="c">The customer to update.</param>
        /// <param name="amount">The amount to add to the balance.</param>
        public static void AddBalance(Costumer c, float amount)
        {
            foreach (Costumer existingCustomer in listCostumers)
            {
                if (existingCustomer.Equals(c))
                {
                    existingCustomer.Balance += amount;
                    return;
                }
            }
            throw new Exception();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="zipCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="nif"></param>
        /// <returns></returns>
        public static bool UpdateCostumer(Costumer u, string email, string pass, string name, string address, int zipCode, int phoneNumber, int nif)
        {
            foreach(Costumer existingCostumer in listCostumers)
            {
                if (existingCostumer.Equals(u))
                {
                    existingCostumer.UserName = name;
                    existingCostumer.Address = address;
                    existingCostumer.ZipCode = zipCode;
                    existingCostumer.PhoneNumber = phoneNumber;
                    existingCostumer.Nif = nif;
                    existingCostumer.Email = email;
                    existingCostumer.Password = pass;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool DeleteAllCostumers()
        {
            listCostumers.Clear();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool DeleteCostumer(Costumer c)
        {
            if(listCostumers.Remove(c)) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NumCostumers()
        {
            return listCostumers.Count;
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
                    b.Serialize(stream, listCostumers);
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
                    b.Serialize(stream, listCostumers);
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
