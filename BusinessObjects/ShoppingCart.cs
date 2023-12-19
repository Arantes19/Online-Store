namespace BusinessObjects
{
    /// <summary>
    /// Representes the ShoppingCart
    /// </summary>
    public class ShoppingCart
    {
        #region Attributes

        private int cartId;
        private int itemCount;
        private bool cartStatus;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public ShoppingCart() 
        {
            this.cartId = 0;
            this.itemCount = 0;
            this.cartStatus = false; //empty
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="itemCount"></param>
        /// <param name="cartStatus"></param>
        public ShoppingCart(int id, int itemCount, bool cartStatus)
        {
            this.cartId = id;
            this.itemCount = itemCount;
            this.cartStatus = cartStatus; 
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public int CartId
        {
            get => cartId;
            set => cartId= value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int ItemCount 
        {
            get { return itemCount; }
            set { itemCount = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool CartStatus
        {
            get => cartStatus;
            set { cartStatus = value; }
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is ShoppingCart)
            {
                ShoppingCart s = (ShoppingCart)obj;
                if (this == s) return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Retrieves a string representation of the administrator's information.
        /// </summary>
        /// <returns>A formatted string containing the administrator's information.</returns>
        public string CartInfo()
        {
            return string.Format("ShoppingCart Id: {0}, Items : {1}, Status: {2}", cartId, itemCount, cartStatus);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int CompareTo(ShoppingCart s)
        {
            if (s is null) return 1;
            else return 0;
        }

        #endregion

        #endregion
    }
}
