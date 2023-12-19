/*
*	<copyright file="Payments" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using BusinessObjects;

namespace Data
{
    /// <summary>
    /// Represents the payment.
    /// </summary>
    public class Payments
    {
        #region Atributes

        private static List<Payment> listPayments;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Payments"/> class.
        /// </summary>
        static Payments()
        {
            listPayments = new List<Payment>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Payments"/> class.
        /// </summary>
        public Payments() { }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of payments.
        /// </summary>
        public List<Payment> ListPayments { get { return listPayments; } }

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
