using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Represents a customer, extending the User class.
    /// </summary>
    public class Costumer : User
    {
        #region Atributes

        private string name;
        private string address;
        private int zipCode;
        private int phoneNumber;
        private int nif;
        private static int numCostumers = 0;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes static members of the Customer class.
        /// </summary>
        static Costumer() => numCostumers = 0;

        /// <summary>
        /// Initializes a new instance of the Customer class with default values.
        /// </summary>
        public Costumer()
        {
            email = string.Empty;
            password = string.Empty;
            name = string.Empty;
            address = string.Empty;
            zipCode = 0;
            phoneNumber = 0;
            nif = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Customer class with specified name, email, and password.
        /// </summary>
        /// <param name="name">The name of the customer.</param>
        /// <param name="email">The email address of the customer.</param>
        /// <param name="password">The password for the customer's account.</param>
        public Costumer(string name, string email, string password) : base(email, password) => this.name = name;

        /// <summary>
        /// Initializes a new instance of the Customer class with specified address, zip code, phone number, and NIF.
        /// </summary>
        /// <param name="address">The address of the customer.</param>
        /// <param name="zipCode">The zip code of the customer's address.</param>
        /// <param name="phoneNumber">The phone number of the customer.</param>
        /// <param name="nif">The NIF of the customer.</param>
        public Costumer(string address, int zipCode, int phoneNumber, int nif)
        {
            this.address = address;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.nif = nif;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public string UserName
        {
            set => name = value;
            get { return name; }
        }

        /// <summary>
        /// Gets or sets the address of the customer.
        /// </summary>
        public string Address
        {
            set => address = value;
            get { return address; }
        }

        /// <summary>
        /// Gets or sets the zip code of the customer's address.
        /// </summary>
        public int ZipCode
        {
            set
            {
                if (value > 0)
                    zipCode = value;
            }
            get { return zipCode; }
        }

        /// <summary>
        /// Gets or sets the phone number of the customer.
        /// </summary>
        public int PhoneNumber
        {
            set
            {
                if (value > 0)
                    phoneNumber = value;
            }
            get { return phoneNumber; }
        }

        /// <summary>
        /// Gets or sets the NIF of the customer.
        /// </summary>
        public int Nif
        {
            set
            {
                if (value > 0)
                    nif = value;
            }
            get { return nif; }
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the customer's information.
        /// </summary>
        /// <returns>A string containing the customer's information.</returns>
        public override string ToString()
        {
            return CostumerInfo();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Costumer)
            {
                Costumer c = (Costumer)obj;
                if (this == c)
                    return true;
            }
            return false;
        }

        #endregion

        #region OtherMethods

        /// <summary>
        ///  Retrieves a string representation of the customer's information.
        /// </summary>
        /// <returns>A formatted string containing the customer's information.</returns>
        public string CostumerInfo()
        {
            return string.Format("Name: {0}, Email: {1}, Password: {2}, Address: {3}, ZipCode: {4}, PhoneNumber: {5}, NIF: {6}", name, email, password, address, zipCode, phoneNumber, nif);
        }

        /// <summary>
        /// Checks if a customer with the specified NIF already exists in the given array of customers.
        /// </summary>
        /// <param name="costumers">The array of customers to search through.</param>
        /// <param name="nif">The NIF to check for existence.</param>
        /// <returns>True if a customer with the specified NIF exists; otherwise, false.</returns>
        public bool ExistCostumer(Costumer[] costumers, int nif)
        {
            foreach (Costumer c in costumers)
                if (c.nif == nif) return true;
            return false;
        }

        #endregion

        #endregion
    }
}
