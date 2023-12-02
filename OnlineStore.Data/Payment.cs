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
    /// Represents the payment 
    /// </summary>
    public class Payment : Order
    {
        #region Properties
        #endregion

        #region Methods

        #region Constructors

        public Payment(int orderId, int totalAmmount) : base(orderId, totalAmmount)
        {
        }

        #endregion

        #endregion
    }
}
