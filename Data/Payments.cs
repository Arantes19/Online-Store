using BusinessObjects;

namespace Data
{
    /// <summary>
    /// Represents the payment 
    /// </summary>
    public class Payments
    {
        #region Atributes

        private static List<Payment> listPayments;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        static Payments()
        {
            listPayments = new List<Payment>();
        }

        public Payments() { }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<Payment> ListPayments { get { return listPayments; }}

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region Other Methods
        #endregion


        #endregion
    }
}
