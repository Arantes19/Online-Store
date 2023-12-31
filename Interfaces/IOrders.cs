/*
*	<copyright file="IOrders" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using BusinessObjects;

namespace Interfaces
{
    /// <summary>
    /// Interface for managing orders.
    /// </summary>
    public interface IOrders
    {
        /// <summary>
        /// Retrieves a list of all orders.
        /// </summary>
        /// <returns>List of orders.</returns>
        List<Order> GetAllOrders();

        /// <summary>
        /// Checks if an order with the specified ID exists.
        /// </summary>
        /// <param name="id">The ID of the order.</param>
        /// <returns>True if the order exists; otherwise, false.</returns>
        bool ExistOrder(int id);

        /// <summary>
        /// Deletes all orders.
        /// </summary>
        /// <returns>True if deletion is successful; otherwise, false.</returns>
        bool DeleteOrders();

        /// <summary>
        /// Deletes an order by its ID.
        /// </summary>
        /// <param name="id">The ID of the order to delete.</param>
        /// <returns>True if deletion is successful; otherwise, false.</returns>
        bool DeleteOrderById(int id);

        /// <summary>
        /// Reads orders from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read.</param>
        /// <returns>True if reading is successful; otherwise, false.</returns>
        bool ReadOrdersFile(string filename);

        /// <summary>
        /// Saves orders to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if saving is successful; otherwise, false.</returns>
        bool SaveOrdersFile(string filename);
    }
}
