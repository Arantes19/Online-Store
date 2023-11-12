using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Order
{
    public class Order
    {
        #region Attributes

        private int orderId;
        private int totalAmmount;
        private List<Order> orders;

        #endregion

        #region Methods

        #region Constructors

        public Order(int orderId, int totalAmmount)
        {
            this.orderId = orderId;
        }

        #endregion

        #region Properties

        public int OrderId
        { get { return orderId; } }

        public int TotalAmmount
        { get { return totalAmmount; } }


        #endregion

        #region Overrides
        #endregion

        #endregion
    }
}