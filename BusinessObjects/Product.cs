/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

namespace BusinessObjects
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
        public int Price
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

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #endregion
    }
}
