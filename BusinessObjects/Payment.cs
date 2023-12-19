namespace BusinessObjects
{
    /// <summary>
    /// Represents the payment 
    /// </summary>
    public class Payment
    {
        #region Attributes

        private string paymentMethod;
        private float ammountPaid;
        private DateTime paymentDate;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Payment class.
        /// </summary>
        public Payment()
        {
            this.paymentMethod = string.Empty;
            this.ammountPaid = 0.0f;
            this.paymentDate = DateTime.MinValue;
        }

        /// <summary>
        /// Initializes a new instance of the Payment class with specified payment details.
        /// </summary>
        /// <param name="paymentMethod">The payment method used.</param>
        /// <param name="amountPaid">The amount paid for the order.</param>
        /// <param name="paymentDate">The date and time of the payment.</param>
        public Payment(string paymentMethod, float amountPaid, DateTime paymentDate)
        {
            this.paymentMethod = paymentMethod;
            this.ammountPaid = amountPaid;
            this.paymentDate = paymentDate;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string PaymentMethod 
        {
            get => paymentMethod; 
            set => paymentMethod = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public float AmmountPaid
        {
            get => ammountPaid;
            set => ammountPaid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime PaymentDate
        {
            get => paymentDate; 
            set => paymentDate = value;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Checks if two payments are equal based on their payment method.
        /// </summary>
        public static bool operator ==(Payment a, Payment b)
        {
            return a.paymentMethod == b.paymentMethod;
        }

        /// <summary>
        /// Checks if two payments are not equal based on their payment method.
        /// </summary>
        public static bool operator !=(Payment a, Payment b)
        {
            return !(a == b);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Payment)
            {
                Payment p = (Payment)obj;
                if(this == p) return true;
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
