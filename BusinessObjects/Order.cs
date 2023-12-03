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


        //private List<Orders> orders;
        //private List<Product.Product> product;
        private List<Order> orders;
        private List<Product> product;

        #endregion

        #region Methods 

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="totalAmmount">The total amount associated with the order.</param>
        public Orders(int orderId, int totalAmmount)
        {
            this.orderId = orderId;
            this.totalAmmount = totalAmmount;
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
        public int TotalAmmount
        {
            get { return totalAmmount; }
            set => totalAmmount = value;
        }

        #endregion

        #region Overrides
        #endregion

        #endregion
    }
}
