using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Representes the ShoppingCart
    /// </summary>
    public class ShoppingCart
    {
        #region Attributes

        private int itemCount;
        private bool isCartEmpty;
        private bool isCartFull;
        private float totalPrice;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public ShoppingCart() 
        {
            this.itemCount = 0;
            this.isCartEmpty = false;
            this.isCartFull = false;
            this.totalPrice = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCount"></param>
        /// <param name="isCartEmpty"></param>
        /// <param name="isCartFull"></param>
        /// <param name="totalPrice"></param>
        public ShoppingCart(int itemCount, bool isCartEmpty, bool isCartFull, float totalPrice)
        {
            this.itemCount = itemCount;
            this.isCartEmpty = isCartEmpty;
            this.isCartFull = isCartFull;
            this.totalPrice = totalPrice; 
        }

        #endregion

        #region Properties

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
        public bool IsCartFull
        {
            get => isCartFull;
            set { isCartFull = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsCartEmpty
        {
            get => isCartEmpty;
            set { isCartEmpty = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float TotalPrice
        {
            get => totalPrice;
            set { totalPrice = value; }
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
        #endregion

        #endregion
    }
}
