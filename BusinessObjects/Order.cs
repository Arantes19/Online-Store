namespace BusinessObjects
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order
    {
        #region Attributes

        private int orderId;
        private int totalAmmount;
        private DateOnly orderDate; //order request date
        private DateOnly shippingDate; //expected shipping date
        private bool deliveryStatus;
        private bool paymentStatus;

        #endregion

        #region Methods 

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public Order()
        {
            this.orderId = 0;
            this.totalAmmount = 0;
            this.orderDate = DateOnly.MinValue;
            this.shippingDate = DateOnly.MinValue;
            this.deliveryStatus = false;
            this.paymentStatus = false;
        }

        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="totalAmmount">The total amount associated with the order.</param>
        public Order(int orderId, int totalAmmount, DateOnly orderDate, DateOnly shippingDate, bool deliveryStatus, bool paymentStaus)
        {
            this.orderId = orderId;
            this.totalAmmount = totalAmmount;
            this.orderDate = orderDate;
            this.shippingDate = shippingDate;
            this.deliveryStatus = deliveryStatus;
            this.paymentStatus = paymentStaus;
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
            set
            {
                if (value > 0) totalAmmount = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateOnly OrderDate
        {
            get { return orderDate; }
            set => orderDate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateOnly ShippingDate
        {
            get => shippingDate; 
            set => shippingDate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool DeliveryStatus
        {
            get => deliveryStatus;
            set => deliveryStatus = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool PaymentStatus 
        {
            get => paymentStatus;
            set => paymentStatus = value;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator ==(Order a, Order b)
        {
            if (a.orderId == b.orderId)
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator !=(Order a, Order b)
        {
            return (!(a == b));
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the order's information.
        /// </summary>
        /// <returns>A string containing the administrator's information.</returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
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
        public string OrderInfo()
        {
            return string.Format("Order ID: {0}, Order Ammount : {1}, Order Date: {2}, Shipping Date: {3}" +
                "Delivery Status: {4}, Payment Status: {5}", orderId, totalAmmount, orderDate, shippingDate, deliveryStatus, paymentStatus);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int CompareTo(Order o)
        {
            if (o is null) return 1;
            else return 0;
        }

        #endregion

        #endregion
    }
}
