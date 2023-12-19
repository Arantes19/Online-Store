/*
*	<copyright file="IProducts" company="IPCA">
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
    /// Interface for managing product-related operations.
    /// </summary>
    public interface IProducts
    {
        /// <summary>
        /// Retrieves a list of all products.
        /// </summary>
        /// <returns>A list containing all products.</returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// Checks if a product with the specified ID exists.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>The product with the specified ID, or null if not found.</returns>
        Product ExistProduct(int id);

        /// <summary>
        /// Inserts a new product.
        /// </summary>
        /// <param name="p">The product to insert.</param>
        /// <returns>True if the product was inserted successfully; otherwise, false.</returns>
        bool InsertProduct(Product p);

        /// <summary>
        /// Verifies if a product ID is valid (not already in use).
        /// </summary>
        /// <param name="id">The ID to verify.</param>
        /// <returns>True if the ID is valid; otherwise, false.</returns>
        bool VerifyProductId(int id);

        /// <summary>
        /// Updates the details of a product.
        /// </summary>
        /// <param name="p">The product to update.</param>
        /// <param name="name">The new name.</param>
        /// <param name="desc">The new description.</param>
        /// <param name="price">The new price.</param>
        /// <param name="quant">The new quantity.</param>
        /// <returns>True if the product was updated successfully; otherwise, false.</returns>
        bool UpdateProductDetails(Product p, string name, string desc, float price, int quant);

        /// <summary>
        /// Deletes all products.
        /// </summary>
        /// <returns>True if all products were deleted successfully; otherwise, false.</returns>
        bool DeleteAllProducts();

        /// <summary>
        /// Deletes a specific product.
        /// </summary>
        /// <param name="p">The product to delete.</param>
        /// <returns>True if the product was deleted successfully; otherwise, false.</returns>
        bool DeleteProduct(Product p);

        /// <summary>
        /// Gets the number of products.
        /// </summary>
        /// <returns>The number of products.</returns>
        int NumProducts();

        /// <summary>
        /// Reads product data from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        bool ReadProductsFile(string filename);

        /// <summary>
        /// Saves product data to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        bool SaveProductsFile(string filename);
    }
}
