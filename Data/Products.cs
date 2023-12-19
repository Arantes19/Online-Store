/*
*	<copyright file="Products" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using BusinessObjects;
using System.Runtime.Serialization.Formatters.Binary;

namespace Data
{
    /// <summary>
    /// Represents a product.
    /// </summary>
    public class Products
    {
        #region Attributes

        private static List<Product> listProducts;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Products"/> class.
        /// </summary>
        static Products()
        {
            listProducts = new List<Product>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Products"/> class.
        /// </summary>
        public Products()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of products.
        /// </summary>
        public List<Product> ListOfProducts { get { return listProducts.ToList(); } }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Gets a list of all products.
        /// </summary>
        /// <returns>A copy of the list of all products.</returns>
        public static List<Product> GetAllProducts()
        {
            return new List<Product>(listProducts);
        }

        /// <summary>
        /// Checks if a product with the specified ID exists.
        /// </summary>
        /// <param name="id">The ID of the product to check.</param>
        /// <returns>The existing product with the specified ID.</returns>
        public static Product ExistProduct(int id)
        {
            foreach (Product existingProduct in listProducts)
            {
                if (existingProduct.Id == id)
                    return existingProduct;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inserts a new product.
        /// </summary>
        /// <param name="p">The product to insert.</param>
        /// <returns>True if the product is inserted successfully; otherwise, an exception is thrown.</returns>
        /// <exception cref="Exception">Thrown if the product already exists.</exception>
        public static bool InsertProduct(Product p)
        {
            foreach (Product existingProduct in listProducts)
            {
                if (existingProduct.Equals(p)) throw new Exception();
            }
            listProducts.Add(p);
            listProducts.Sort();
            return true;
        }

        /// <summary>
        /// Verifies if a product with the specified ID exists.
        /// </summary>
        /// <param name="id">The ID of the product to verify.</param>
        /// <returns>True if the product ID is valid; otherwise, false.</returns>
        public static bool VerifyProductId(int id)
        {
            foreach (Product p in listProducts)
            {
                if (p.Id == id) return false;
            }
            return true;
        }

        /// <summary>
        /// Updates the details of an existing product.
        /// </summary>
        /// <param name="p">The existing product to update.</param>
        /// <param name="name">The new name of the product.</param>
        /// <param name="desc">The new description of the product.</param>
        /// <param name="price">The new price of the product.</param>
        /// <param name="quant">The new quantity of the product.</param>
        /// <returns>True if the update is successful; otherwise, an exception is thrown.</returns>
        /// <exception cref="Exception">Thrown if the product does not exist.</exception>
        public static bool UpdateProductDetails(Product p, string name, string desc, float price, int quant)
        {
            foreach (Product existingProduct in listProducts)
            {
                if (existingProduct.Equals(p))
                {
                    existingProduct.Name = name;
                    existingProduct.Description = desc;
                    existingProduct.Price = price;
                    existingProduct.Quantity = quant;
                    return true;
                }
            }
            throw new Exception();
        }

        /// <summary>
        /// Deletes all products.
        /// </summary>
        /// <returns>True if all products are deleted successfully.</returns>
        public static bool DeleteAllProducts()
        {
            listProducts.Clear();
            return true;
        }

        /// <summary>
        /// Deletes a specific product.
        /// </summary>
        /// <param name="p">The product to delete.</param>
        /// <returns>True if the product is deleted successfully.</returns>
        public static bool DeleteProduct(Product p)
        {
            if (listProducts.Remove(p)) return true;
            return false;
        }

        /// <summary>
        /// Gets the number of products.
        /// </summary>
        /// <returns>The number of products.</returns>
        public static int NumProducts()
        {
            return listProducts.Count;
        }

        /// <summary>
        /// Reads products from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if the read operation is successful.</returns>
        /// <exception cref="Exception">Thrown if there is an error during the read operation.</exception>
        public static bool ReadProductsFile(string filename)
        {
            try
            {
                if (!File.Exists(filename)) return false;
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listProducts);
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
        /// Saves products to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the save operation is successful.</returns>
        /// <exception cref="Exception">Thrown if there is an error during the save operation.</exception>
        public static bool SaveProductsFile(string filename)
        {
            try
            {
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listProducts);
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
