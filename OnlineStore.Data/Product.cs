/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

namespace OnlineStore.Data
{
    /// <summary>
    /// Represents a product.
    /// </summary>
    public class Product
    {
        #region Attributes

        private int id;
        private string name;
        private string description;
        private int price;
        private int quantity;
        private static int numProducts = 0;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes static members of the Product class.
        /// </summary>
        static Product() => numProducts = 0;

        /// <summary>
        /// Initializes a new instance of the Product class with default values.
        /// </summary>
        public Product()
        {
            id = 0;
            name = string.Empty;
            description = string.Empty;
            price = 0;
            quantity = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Product class with specified name, description, price and quantity.
        /// </summary>
        /// <param name="name">The name of the product</param>
        /// <param name="description">the description of the product</param>
        /// <param name="price">The price of the product</param>
        /// <param name="quantity">The quantity of the product</param>
        public Product(string name, string description, double price, int quantity)
        {
            this.name = name;
            this.description = description;
            this.price = (int)price;
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
        /// Gets or sets the description of the product
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
        public double Price
        {
            set => price = (int)value;
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
            return string.Format("Name: {0}, Description: {1}, Price: {2}, Quantity: {3}", name, description, price, quantity);
        }

        /// <summary>
        /// Checks if a product with the specified key already exists in the given array of products.
        /// </summary>
        /// <param name="products">The array of products to search through.</param>
        /// <param name="id">The id to check for existence.</param>
        /// <returns>True if an product with the specified id exists; otherwise, false.</returns>
        public bool ExistAdmin(Product[] products, int id)
        {
            foreach (Product a in products)
                if (a.id == id) return true;
            return false;
        }

        /// <summary>
        /// Method not implemented
        /// </summary>
        /// <returns>NotImplementedException</returns>
        /// <exception cref="NotImplementedException"></exception>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion
    }
}
