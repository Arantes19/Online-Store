/*
*	<copyright file="Product" company="IPCA">
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
    /// Represents a product.
    /// </summary>
    public class Product
    {
        #region Attributes

        private int id;
        private string name;
        private string description;
        private float price;
        private int quantity;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Product class with default values.
        /// </summary>
        public Product()
        {
            this.id = 0;
            this.name = string.Empty;
            this.description = string.Empty;
            this.price = 0.0f;
            this.quantity = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Product class with specified values.
        /// </summary>
        /// <param name="id">The unique identifier of the product.</param>
        /// <param name="name">The name of the product.</param>
        /// <param name="description">The description of the product.</param>
        /// <param name="price">The price of the product.</param>
        /// <param name="quantity">The quantity of the product.</param>
        public Product(int id, string name, string description, float price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name
        {
            set => name = value;
            get { return name; }
        }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description
        {
            set => description = value;
            get { return description; }
        }

        /// <summary>
        /// Gets or sets the unique identifier of the product.
        /// </summary>
        public int Id
        {
            set => id = value;
            get { return id; }
        }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public float Price
        {
            set => price = value;
            get { return price; }
        }

        /// <summary>
        /// Gets or sets the quantity of the product.
        /// </summary>
        public int Quantity
        {
            set => quantity = value;
            get { return quantity; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Equality operator for checking if two products are equal based on their unique identifier.
        /// </summary>
        public static bool operator ==(Product a, Product b)
        {
            return a.id == b.id;
        }

        /// <summary>
        /// Inequality operator for checking if two products are not equal based on their unique identifier.
        /// </summary>
        public static bool operator !=(Product a, Product b)
        {
            return !(a == b);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the product's information.
        /// </summary>
        /// <returns>A string containing the product's information.</returns>
        public override string ToString()
        {
            return ProductInfo();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Product)
            {
                Product p = (Product)obj;
                if (this == p)
                    return true;
            }
            return false;
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Retrieves a string representation of the product's information.
        /// </summary>
        /// <returns>A formatted string containing the product's information.</returns>
        public string ProductInfo()
        {
            return string.Format("Product ID: {0}, Product Name: {1}, Description: {2}, Price: {3}, Quantity: {4}",
                id, name, description, price, quantity);
        }

        /// <summary>
        /// Compares the product to an admin and returns the result.
        /// </summary>
        /// <param name="a">The admin to compare with.</param>
        /// <returns>1 if the admin is null; otherwise, 0.</returns>
        public int CompareTo(Admin a)
        {
            if (a is null) return 1;
            else return 0;
        }

        /// <summary>
        /// Gets the hash code for this object.
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