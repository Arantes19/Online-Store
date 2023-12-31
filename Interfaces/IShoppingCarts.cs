/*
*	<copyright file="IShoppingCarts" company="IPCA">
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
    /// Interface for managing shopping carts.
    /// </summary>
    public interface IShoppingCarts
    {
        /// <summary>
        /// Retrieves a list of all shopping carts.
        /// </summary>
        /// <returns>List of shopping carts.</returns>
        List<ShoppingCart> getAllShoppingCarts();

        /// <summary>
        /// Checks if a shopping cart exists.
        /// </summary>
        /// <param name="s">The shopping cart to check.</param>
        /// <returns>True if the shopping cart exists; otherwise, false.</returns>
        bool ExistShoppingCart(ShoppingCart s);

        /// <summary>
        /// Deletes all shopping carts.
        /// </summary>
        /// <returns>True if deletion is successful; otherwise, false.</returns>
        bool DeleteAllShopingCarts();

        /// <summary>
        /// Deletes a shopping cart by its ID.
        /// </summary>
        /// <param name="id">The ID of the shopping cart to delete.</param>
        /// <returns>True if deletion is successful; otherwise, false.</returns>
        bool DeleteShoppingCart(int id);

        /// <summary>
        /// Gets the number of shopping carts.
        /// </summary>
        /// <returns>The number of shopping carts.</returns>
        int NumCarts();

        /// <summary>
        /// Reads shopping carts from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read.</param>
        /// <returns>True if reading is successful; otherwise, false.</returns>
        bool ReadShoppingCartsFile(string filename);

        /// <summary>
        /// Saves shopping carts to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if saving is successful; otherwise, false.</returns>
        bool SaveShoppingCartsFile(string filename);
    }
}