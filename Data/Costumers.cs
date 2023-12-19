/*
*	<copyright file="Costumers" company="IPCA">
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
        /// Initializes a new instance of the <see cref="Costumers"/> class.
        /// The default Constructor.
        /// </summary>
        static Costumers()
        {
            listCostumers = new List<Costumer>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Costumers"/> class.
        /// </summary>
        public Costumers()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of customers.
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
        /// <returns>The authenticated customer if successful; otherwise, throws <see cref="NotImplementedException"/>.</returns>
        public static Costumer GetCostumerByEmail(string email)
        {
            foreach (Costumer costumer in listCostumers)
            {
                if (costumer.Email == email)
                {
                    return costumer;
                }
            }
            throw new NotImplementedException();
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
        /// Checks if a customer with the given NIF exists.
        /// </summary>
        /// <param name="nif">The NIF to check.</param>
        /// <returns>True if a customer with the given NIF exists; otherwise, false.</returns>
        public static bool ExistCostumer(int nif)
        {
            foreach (Costumer existingCostumer in listCostumers)
            {
                if (existingCostumer.Nif == nif) return true;
            }
            return false;
        }

        /// <summary>
        /// Inserts a new customer.
        /// </summary>
        /// <param name="c">The customer to insert.</param>
        /// <returns>True if the customer is inserted successfully; otherwise, throws <see cref="Exception"/>.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during insertion.</exception>
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
        /// <returns>True if the balance is added successfully; otherwise, throws <see cref="Exception"/>.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during the update.</exception>
        public static bool AddBalance(Costumer c, float amount)
        {
            foreach (Costumer existingCustomer in listCostumers)
            {
                if (existingCustomer.Equals(c))
                {
                    existingCustomer.Balance += amount;
                    return true;
                }
            }
            throw new Exception();
        }

        /// <summary>
        /// Updates the information of a customer.
        /// </summary>
        /// <param name="u">The customer to update.</param>
        /// <param name="email">The new email.</param>
        /// <param name="pass">The new password.</param>
        /// <param name="name">The new username.</param>
        /// <param name="address">The new address.</param>
        /// <param name="zipCode">The new zip code.</param>
        /// <param name="phoneNumber">The new phone number.</param>
        /// <param name="nif">The new NIF.</param>
        /// <returns>True if the customer is updated successfully; otherwise, false.</returns>
        public static bool UpdateCostumer(Costumer u, string email, string pass, string name, string address, int zipCode, int phoneNumber, int nif)
        {
            foreach (Costumer existingCostumer in listCostumers)
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
        /// Deletes all customers.
        /// </summary>
        /// <returns>True if all customers are deleted successfully; otherwise, false.</returns>
        public static bool DeleteAllCostumers()
        {
            listCostumers.Clear();
            return true;
        }

        /// <summary>
        /// Deletes a customer.
        /// </summary>
        /// <param name="c">The customer to delete.</param>
        /// <returns>True if the customer is deleted successfully; otherwise, false.</returns>
        public static bool DeleteCostumer(Costumer c)
        {
            if (listCostumers.Remove(c)) return true;
            return false;
        }

        /// <summary>
        /// Gets the number of customers.
        /// </summary>
        /// <returns>The number of customers.</returns>
        public static int NumCostumers()
        {
            return listCostumers.Count;
        }

        /// <summary>
        /// Reads customers from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if customers are read successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during reading.</exception>
        public static bool ReadCostumersFile(string filename)
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
        /// Saves customers to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if customers are saved successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during saving.</exception>
        public static bool SaveCostumersFile(string filename)
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
