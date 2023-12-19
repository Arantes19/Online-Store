/*
*	<copyright file="Payment" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

namespace BusinessObjects
{
    /// <summary>
    /// Represents the payment.
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
        /// Initializes a new instance of the Payment class with default values.
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
        /// Gets or sets the payment method.
        /// </summary>
        public string PaymentMethod
        {
            get => paymentMethod;
            set => paymentMethod = value;
        }

        /// <summary>
        /// Gets or sets the amount paid for the order.
        /// </summary>
        public float AmmountPaid
        {
            get => ammountPaid;
            set => ammountPaid = value;
        }

        /// <summary>
        /// Gets or sets the date and time of the payment.
        /// </summary>
        public DateTime PaymentDate
        {
            get => paymentDate;
            set => paymentDate = value;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Equality operator for checking if two payments are equal based on their payment method.
        /// </summary>
        public static bool operator ==(Payment a, Payment b)
        {
            return a.paymentMethod == b.paymentMethod;
        }

        /// <summary>
        /// Inequality operator for checking if two payments are not equal based on their payment method.
        /// </summary>
        public static bool operator !=(Payment a, Payment b)
        {
            return !(a == b);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Payment)
            {
                Payment p = (Payment)obj;
                if (this == p)
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
        #endregion

        #endregion
    }
}
