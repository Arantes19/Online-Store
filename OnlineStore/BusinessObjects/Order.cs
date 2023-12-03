using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order
    {
        #region Attributes

        private int orderId;
        private int orderAmmount;
        //private List<Orders> orders;
        //private List<Product.Product> product;

        #endregion

        #region Methods 

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="totalAmmount">The total amount associated with the order.</param>
        public Order(int orderId, int orderAmmount)
        {
            this.orderId = orderId;
            this.orderAmmount = orderAmmount;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the unique identifier of the order.
        /// </summary>
        public int OrderId
        {
            get { return orderId; }
            set => orderId = value;
        }

        /// <summary>
        /// Gets the total amount associated with the order.
        /// </summary>
        public int OrderAmmount
        {
            get { return orderAmmount; }
            set => orderAmmount = value;
        }

        #endregion

        #region Overrides
        #endregion

        #endregion
    }
}
