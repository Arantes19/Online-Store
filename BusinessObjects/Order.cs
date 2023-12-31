/*
*	<copyright file="Order" company="IPCA">
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
    /// Represents an order.
    /// </summary>
    public class Order
    {
        #region Attributes

        private int orderId;
        private int totalAmmount;
        private DateOnly orderDate; // order request date
        private DateOnly shippingDate; // expected shipping date
        private OrderStatus orderStatus;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Order class with default values.
        /// </summary>
        public Order()
        {
            this.orderId = 0;
            this.totalAmmount = 0;
            this.orderDate = DateOnly.MinValue;
            this.shippingDate = DateOnly.MinValue;
            this.orderStatus = OrderStatus.Null;
        }

        /// <summary>
        /// Initializes a new instance of the Order class with specified values.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="totalAmmount">The total amount associated with the order.</param>
        /// <param name="orderDate">The order request date.</param>
        /// <param name="shippingDate">The expected shipping date.</param>
        /// <param name="orderStatus">The order status.</param>
        public Order(int orderId, int totalAmmount, DateOnly orderDate, DateOnly shippingDate, OrderStatus orderStatus)
        {
            this.orderId = orderId;
            this.totalAmmount = totalAmmount;
            this.orderDate = orderDate;
            this.shippingDate = shippingDate;
            this.orderStatus = orderStatus;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the unique identifier of the order.
        /// </summary>
        public int OrderId
        {
            get { return orderId; }
            set => orderId = value;
        }

        /// <summary>
        /// Gets or sets the total amount associated with the order.
        /// </summary>
        public int TotalAmmount
        {
            get { return totalAmmount; }
            set
            {
                if (value > 0) totalAmmount = value;
            }
        }

        /// <summary>
        /// Gets or sets the order request date.
        /// </summary>
        public DateOnly OrderDate
        {
            get { return orderDate; }
            set => orderDate = value;
        }

        /// <summary>
        /// Gets or sets the expected shipping date.
        /// </summary>
        public DateOnly ShippingDate
        {
            get => shippingDate;
            set => shippingDate = value;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Equality operator for comparing two Order objects based on orderId.
        /// </summary>
        /// <param name="a">The first Order object.</param>
        /// <param name="b">The second Order object.</param>
        /// <returns>True if the orderIds are equal; otherwise, false.</returns>
        public static bool operator ==(Order a, Order b)
        {
            if (a.orderId == b.orderId)
                return true;
            return false;
        }

        /// <summary>
        /// Inequality operator for comparing two Order objects based on orderId.
        /// </summary>
        /// <param name="a">The first Order object.</param>
        /// <param name="b">The second Order object.</param>
        /// <returns>True if the orderIds are not equal; otherwise, false.</returns>
        public static bool operator !=(Order a, Order b)
        {
            return !(a == b);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the order's information.
        /// </summary>
        /// <returns>A string containing the order's information.</returns>
        public override string ToString()
        {
            return OrderInfo();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Order)
            {
                Order o = (Order)obj;
                if (this == o)
                    return true;
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
        /// Retrieves a string representation of the order's information.
        /// </summary>
        /// <returns>A formatted string containing the order's information.</returns>
        public string OrderInfo()
        {
            return string.Format("Order ID: {0}, Order Amount: {1}, Order Date: {2}, Shipping Date: {3}, Order Status: {4}",
                orderId, totalAmmount, orderDate, shippingDate, orderStatus);
        }

        /// <summary>
        /// Compares this Order object with another Order object.
        /// </summary>
        /// <param name="o">The Order object to compare.</param>
        /// <returns>0 if the objects are equal; otherwise, a non-zero value.</returns>
        public int CompareTo(Order o)
        {
            if (o is null) return 1;
            else return 0;
        }

        /// <summary>
        /// Represents the possible status values for an order.
        /// </summary>
        public enum OrderStatus { Null, Processing, Shipped, Delivered }

        #endregion

        #endregion
    }
}