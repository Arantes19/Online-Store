/*
*	<copyright file="ICostumers" company="IPCA">
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
    /// Interface for managing customer-related operations.
    /// </summary>
    public interface ICostumers
    {
        /// <summary>
        /// Gets a customer by email.
        /// </summary>
        /// <param name="email">The email address of the customer.</param>
        /// <returns>The customer with the specified email, or null if not found.</returns>
        Costumer GetCostumerByEmail(string email);

        /// <summary>
        /// Retrieves a list of all customers.
        /// </summary>
        /// <returns>A list containing all customers.</returns>
        List<Costumer> GetAllCustomers();

        /// <summary>
        /// Checks if a customer with the specified NIF exists.
        /// </summary>
        /// <param name="nif">The NIF (Tax Identification Number) of the customer.</param>
        /// <returns>True if the customer exists; otherwise, false.</returns>
        bool ExistCostumer(int nif);

        /// <summary>
        /// Inserts a new customer.
        /// </summary>
        /// <param name="c">The customer to insert.</param>
        /// <returns>True if the customer was inserted successfully; otherwise, false.</returns>
        bool InsertCostumer(Costumer c);

        /// <summary>
        /// Adds balance to the customer's account.
        /// </summary>
        /// <param name="c">The customer to update.</param>
        /// <param name="amount">The amount to add to the balance.</param>
        /// <returns>True if the balance was added successfully; otherwise, false.</returns>
        bool AddBalance(Costumer c, float amount);

        /// <summary>
        /// Updates the details of a customer.
        /// </summary>
        /// <param name="u">The customer to update.</param>
        /// <param name="email">The new email address.</param>
        /// <param name="pass">The new password.</param>
        /// <param name="name">The new name.</param>
        /// <param name="address">The new address.</param>
        /// <param name="zipCode">The new ZIP code.</param>
        /// <param name="phoneNumber">The new phone number.</param>
        /// <param name="nif">The new NIF.</param>
        /// <returns>True if the customer was updated successfully; otherwise, false.</returns>
        bool UpdateCostumer(Costumer u, string email, string pass, string name, string address, int zipCode, int phoneNumber, int nif);

        /// <summary>
        /// Deletes all customers.
        /// </summary>
        /// <returns>True if all customers were deleted successfully; otherwise, false.</returns>
        bool DeleteAllCostumers();

        /// <summary>
        /// Deletes a specific customer.
        /// </summary>
        /// <param name="c">The customer to delete.</param>
        /// <returns>True if the customer was deleted successfully; otherwise, false.</returns>
        bool DeleteCostumer(Costumer c);

        /// <summary>
        /// Gets the number of customers.
        /// </summary>
        /// <returns>The number of customers.</returns>
        int NumCostumers();

        /// <summary>
        /// Reads customer data from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        bool ReadCostumersFile(string filename);

        /// <summary>
        /// Saves customer data to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        bool SaveCostumersFile(string filename);
    }
}
