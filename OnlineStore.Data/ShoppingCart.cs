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
    /// Representes the ShoppingCart
    /// </summary>
    public class ShoppingCart : Order
    {
        #region Attributes

        private ushort itemCount;
        private bool isCartEmpty;
        private bool isCartFull;
        //private bool cart_status; //maybe it will be needed
        private uint totalPrice;


        #endregion

        #region Methods

        #region Constructors

        public ShoppingCart(int orderId, int totalAmmount) : base(orderId, totalAmmount)
        {
        }

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