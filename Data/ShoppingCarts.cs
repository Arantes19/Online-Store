/*
*	<copyright file="ShoppingCarts" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using BusinessObjects;
using System.Runtime.Serialization.Formatters.Binary;
using static Exceptions.FileExceptions;

namespace Data
{
    /// <summary>
    /// Represents the ShoppingCart.
    /// </summary>
    public class ShoppingCarts
    {
        #region Attributes

        private static List<ShoppingCart> listShoppingCarts;
        private List<Product> listProducts;

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCarts"/> class.
        /// </summary>
        static ShoppingCarts()
        {
            listShoppingCarts = new List<ShoppingCart>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCarts"/> class.
        /// </summary>
        public ShoppingCarts()
        {
            listProducts = new List<Product>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of shopping carts.
        /// </summary>
        public List<ShoppingCart> ListShoppingCarts { get { return listShoppingCarts; } }


        /// <summary>
        /// Gets the list of products.
        /// </summary>
        public List<Product> ListProducts { get { return listProducts; } }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Gets a list of all shopping carts.
        /// </summary>
        /// <returns>A copy of the list of all shopping carts.</returns>
        public static List<ShoppingCart> getAllShoppingCarts()
        {
            return new List<ShoppingCart>(listShoppingCarts);
        }

        /// <summary>
        /// Checks if a shopping cart exists.
        /// </summary>
        /// <param name="s">The shopping cart to check.</param>
        /// <returns>True if the shopping cart exists; otherwise, an exception is thrown.</returns>
        /// <exception cref="Exception">Thrown if the shopping cart already exists.</exception>
        public static bool ExistShoppingCart(ShoppingCart s)
        {
            foreach (ShoppingCart existingCart in listShoppingCarts)
            {
                if (existingCart.Equals(s)) throw new Exception();
            }
            listShoppingCarts.Add(s);
            listShoppingCarts.Sort();
            return true;
        }

        /// <summary>
        /// Deletes all shopping carts.
        /// </summary>
        /// <returns>True if all shopping carts are deleted successfully.</returns>
        public static bool DeleteAllShopingCarts()
        {
            listShoppingCarts.Clear();
            return true;
        }

        /// <summary>
        /// Deletes a specific shopping cart by ID.
        /// </summary>
        /// <param name="id">The ID of the shopping cart to delete.</param>
        /// <returns>True if the shopping cart is deleted successfully.</returns>
        public static bool DeleteShoppingCart(int id)
        {
            foreach (ShoppingCart s in listShoppingCarts)
            {
                if (s.CartId == id)
                {
                    listShoppingCarts.Remove(s);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the number of shopping carts.
        /// </summary>
        /// <returns>The number of shopping carts.</returns>
        public static int NumCarts()
        {
            return listShoppingCarts.Count;
        }

        /// <summary>
        /// Reads shopping carts from a file.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if the read operation is successful.</returns>
        /// <exception cref="Exception">Thrown if there is an error during the read operation.</exception>
        public static bool ReadShoppingCartsFile(string filename)
        {
            try
            {
                if (!File.Exists(filename)) return false;
                Stream stream;
                using (stream = File.Open(filename, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listShoppingCarts);
                    stream.Close();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw new ReadFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }

        /// <summary>
        /// Saves shopping carts to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the save operation is successful.</returns>
        /// <exception cref="Exception">Thrown if there is an error during the save operation.</exception>
        public static bool SaveShoppingCartsFile(string filename)
        {
            try
            {
                string fullPath = Path.Combine("C:\\Users\\arant\\Desktop\\LESI\\2-1\\POO\\3.1\\TrabalhoPOO_23504_FaseInt\\Database", filename);
                using(Stream stream = File.Open(fullPath, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listShoppingCarts);
                    stream.Close();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw new SaveFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }
        #endregion

        #endregion
    }
}
