/*
*	<copyright file="ShoppingCart" company="IPCA">
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
    /// Represents the ShoppingCart.
    /// </summary>
    public class ShoppingCart
    {
        #region Attributes

        private int cartId;
        private int itemCount;
        private bool cartStatus;
        private List<Product> listProducts;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the ShoppingCart class with default values.
        /// </summary>
        public ShoppingCart()
        {
            this.cartId = 0;
            this.itemCount = 0;
            this.cartStatus = false; //empty
            this.listProducts = new List<Product>();
        }

        /// <summary>
        /// Initializes a new instance of the ShoppingCart class with specified values.
        /// </summary>
        /// <param name="id">The unique identifier of the shopping cart.</param>
        /// <param name="itemCount">The number of items in the shopping cart.</param>
        /// <param name="cartStatus">The status of the shopping cart (empty or not).</param>
        /// <param name="products">The list of products in the shopping cart.</param>
        public ShoppingCart(int id, int itemCount, bool cartStatus, List<Product> products)
        {
            this.cartId = id;
            this.itemCount = itemCount;
            this.cartStatus = cartStatus;
            this.listProducts = products;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the unique identifier of the shopping cart.
        /// </summary>
        public int CartId
        {
            get => cartId;
            set => cartId = value;
        }

        /// <summary>
        /// Gets or sets the number of items in the shopping cart.
        /// </summary>
        public int ItemCount
        {
            get { return itemCount; }
            set { itemCount = value; }
        }

        /// <summary>
        /// Gets or sets the status of the shopping cart (empty or not).
        /// </summary>
        public bool CartStatus
        {
            get => cartStatus;
            set { cartStatus = value; }
        }

        /// <summary>
        /// Gets the list of products in the shopping cart.
        /// </summary>
        public List<Product> ListProducts { get { return listProducts; } }

        #endregion

        #region Overrides

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is ShoppingCart)
            {
                ShoppingCart s = (ShoppingCart)obj;
                if (this == s) return true;
            }
            return false;
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

        #region OtherMethods

        /// <summary>
        /// Retrieves a string representation of the shopping cart's information.
        /// </summary>
        /// <returns>A formatted string containing the shopping cart's information.</returns>
        public string CartInfo()
        {
            return string.Format("ShoppingCart Id: {0}, Items: {1}, Status: {2}", cartId, itemCount, cartStatus);
        }

        /// <summary>
        /// Compares the shopping cart to another shopping cart and returns the result.
        /// </summary>
        /// <param name="s">The shopping cart to compare with.</param>
        /// <returns>1 if the shopping cart is null; otherwise, 0.</returns>
        public int CompareTo(ShoppingCart s)
        {
            if (s is null) return 1;
            else return 0;
        }

        /// <summary>
        /// Adds a product to the shopping cart.
        /// </summary>
        /// <param name="p">The product to add.</param>
        /// <exception cref="Exception">Thrown if the product is null or already exists in the shopping cart.</exception>
        public void AddProductToCart(Product p)
        {
            if (p != null)
            {
                if (listProducts.Contains(p)) throw new Exception("Product already exists in the shopping cart.");
                listProducts.Add(p);
            }
            else throw new Exception("Product cannot be null.");
        }

        #endregion

        #endregion
    }
}