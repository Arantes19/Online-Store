/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Order
{
    /// <summary>
    /// Representes the ShoppingCart
    /// </summary> 
    public class ShoppingCart : Order
    {
        #region Attributes

        private UInt16 itemCount;
        private bool isCartEmpty;
        private bool isCartFull;
        //private bool cart_status; //maybe it will be needed
        private UInt32 totalPrice;


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