/*
*	<copyright file="Orders" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using System.Runtime.Serialization.Formatters.Binary;
using BusinessObjects;

namespace Data
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Orders
    {
        #region Attributes

        private static List<Order> listOrders;

        #endregion

        #region Methods 

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Orders"/> class.
        /// </summary>
        static Orders()
        {
            listOrders = new List<Order>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Orders"/> class.
        /// </summary>
        public Orders()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of orders.
        /// </summary>
        public List<Order> OrdersList { get { return listOrders; } }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Retrieves a list of all orders.
        /// </summary>
        /// <returns>A copy of the list of all orders.</returns>
        public static List<Order> GetAllOrders()
        {
            return new List<Order>(listOrders);
        }

        /// <summary>
        /// Checks if an order with the given ID exists.
        /// </summary>
        /// <param name="id">The ID to check.</param>
        /// <returns>True if an order with the given ID exists; otherwise, false.</returns>
        public static bool ExistOrder(int id)
        {
            foreach (Order existingOrder in listOrders)
            {
                if (existingOrder.OrderId == id)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes all orders.
        /// </summary>
        /// <returns>True if all orders are deleted successfully; otherwise, false.</returns>
        public static bool DeleteOrders()
        {
            listOrders.Clear();
            return true;
        }

        /// <summary>
        /// Deletes an order by ID.
        /// </summary>
        /// <param name="id">The ID of the order to delete.</param>
        /// <returns>True if the order is deleted successfully; otherwise, false.</returns>
        public static bool DeleteOrderById(int id)
        {
            foreach (Order a in listOrders)
            {
                if (a.OrderId == id)
                {
                    listOrders.Remove(a);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Reads orders from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if orders are read successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during reading.</exception>
        public static bool ReadOrdersFile(string filename)
        {
            try
            {
                if (!File.Exists(filename)) return false;
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listOrders);
                    stream.Close();
                    return true;
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        /// <summary>
        /// Saves orders to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if orders are saved successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during saving.</exception>
        public static bool SaveOrdersFile(string filename)
        {
            try
            {
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listOrders);
                    stream.Close();
                    return true;
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        #endregion

        #endregion
    }
}
