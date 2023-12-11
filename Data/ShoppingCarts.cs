using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Representes the ShoppingCart
    /// </summary>
    public class ShoppingCarts
    {
        #region Attributes

        static List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();
        private ushort itemCount;
        private bool isCartEmpty;
        private bool isCartFull;
        //private bool cart_status; //maybe it will be needed
        private uint totalPrice;

        #endregion

        #region Methods

        #region Constructor

        #endregion

        #region Properties

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}
