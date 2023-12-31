/*
*	<copyright file="Costumer" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

namespace BusinessObjects
{
    [Serializable]
    /// <summary>
    /// Represents a customer, extending the User class.
    /// </summary>
    /// <inheritdoc cref="User"/>
    public class Costumer : User
    {
        #region Atributes

        private string name;
        private string address;
        private int zipCode;
        private int phoneNumber;
        private int nif;
        private float balance;
        private ShoppingCart cart;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Customer class with default values.
        /// </summary>
        /// <inheritdoc cref="User"/>
        public Costumer() : base()
        {
            this.name = string.Empty;
            this.address = string.Empty;
            this.zipCode = -1;
            this.phoneNumber = -1;
            this.nif = -1;
            this.balance = 0.0f;
            this.cart = new ShoppingCart();
        }

        /// <summary>
        /// Initializes a new instance of the Customer class with specified values.
        /// </summary>
        /// <param name="nif">The NIF of the customer.</param>
        /// <param name="name">The name of the customer.</param>
        /// <param name="address">The address of the customer.</param>
        /// <param name="zipCode">The zip code of the customer's address.</param>
        /// <param name="phoneNumber">The phone number of the customer.</param>
        /// <param name="email">The email of the customer</param>
        /// <param name="password">The password of the customer</param>
        /// <param name="balance">The balance of the customer</param>
        /// <param name="cart">The Cart of the customer</param>
        /// <inheritdoc cref="User"/>
        public Costumer(int nif, string name, string address, int zipCode, int phoneNumber, string email, string password, ShoppingCart cart) 
            :base(email, password)
        {
            this.name = name;
            this.nif = nif;
            this.address = address;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.balance = 0.0f;
            this.cart = cart;
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
        /// Gets or sets the Balance of the customer.
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

        /// <summary>
        /// Gets or sets the ShoppingCart of the customer.
        /// </summary>
        public ShoppingCart PersonalCart
        {
            get => cart;
            set => cart = value;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Equality operator for comparing two Costumer objects based on NIF.
        /// </summary>
        /// <param name="a">The first Costumer object.</param>
        /// <param name="b">The second Costumer object.</param>
        /// <returns>True if the NIFs are equal; otherwise, false.</returns>
        public static bool operator == (Costumer a, Costumer b)
        {
            if (a.nif == b.nif) return true;
            return false;
        }

        /// <summary>
        /// Inequality operator for comparing two Costumer objects based on NIF.
        /// </summary>
        /// <param name="a">The first Costumer object.</param>
        /// <param name="b">The second Costumer object.</param>
        /// <returns>True if the NIFs are not equal; otherwise, false.</returns>
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
        /// Retrieves a string representation of the customer's information.
        /// </summary>
        /// <returns>A formatted string containing the customer's information.</returns>
        public string CostumerFile()
        {
            return string.Format("Name: {0}, Email: {1}, Password: {2}, Address: {3}, ZipCode: {4}, PhoneNumber: {5}," +
                "  NIF: {6}, Balance: {7}", name, Email, Password, address, zipCode, phoneNumber, nif, Balance);
        }

        /// <summary>
        /// Compares this Costumer object with another Costumer object.
        /// </summary>
        /// <param name="c">The Costumer object to compare.</param>
        /// <returns>0 if the objects are equal; otherwise, a non-zero value.</returns>
        public int CompareTo(Costumer c)
        {
            if (c is null) return 1;
            else return 0;
        }

        /// <summary>
        /// Returns a hash code for this Costumer object.
        /// </summary>
        /// <returns>A hash code value.</returns>
        /// <exception cref="NotImplementedException">Thrown if GetHashCode is not implemented.</exception>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }


        #endregion

        #endregion
    }
}
