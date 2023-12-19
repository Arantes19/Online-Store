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
    /// <seealso cref="User"/>
    public class Costumer : User
    {
        #region Atributes

        private string name;
        private string address;
        private int zipCode;
        private int phoneNumber;
        private int nif;
        private float balance;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Customer class with default values.
        /// </summary>
        public Costumer() : base()
        {
            this.name = string.Empty;
            this.address = string.Empty;
            this.zipCode = -1;
            this.phoneNumber = -1;
            this.nif = -1;
            this.balance = 0.0f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="zipCode"></param>
        /// <param name="phoneNumber"></param>
        public Costumer(int nif, string name, string address, int zipCode, int phoneNumber, string email, string password, float balance) 
            :base(email, password)
        {
            this.name = name;
            this.nif = nif;
            this.address = address;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.balance = balance;
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

        /// <summary>
        /// 
        /// </summary>
        public float Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                    balance = value;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Costumer a, Costumer b)
        {
            if (a.nif == b.nif) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator != (Costumer a, Costumer b)
        {
           return !(a == b);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the customer's information.
        /// </summary>
        /// <returns>A string containing the customer's information.</returns>
        public override string ToString()
        {
            return CostumerFile();
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
        public string CostumerFile()
        {
            return string.Format("Name: {0}, Email: {1}, Password: {2}, Address: {3}, ZipCode: {4}, PhoneNumber: {5}," +
                "  NIF: {6}, Balance: {7}", name, Email, Password, address, zipCode, phoneNumber, nif, Balance);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int CompareTo(Costumer c)
        {
            if (c is null) return 1;
            else return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion
    }
}
