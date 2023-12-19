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
        /// 
        /// </summary>
        static Products()
        {
            listProducts = new List<Product>();
        }

        /// <summary>
        /// 
        /// </summary>
        public Products()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<Product> ListOfProducts { get { return listProducts.ToList(); } }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetAllProducts()
        {
            return new List<Product>(listProducts);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ExistProduct(int id)
        {
            foreach (Product existingProduct in listProducts)
            {
                if (existingProduct.Id == id)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
       /// 
       /// </summary>
       /// <param name="p"></param>
       /// <param name="name"></param>
       /// <param name="desc"></param>
       /// <param name="price"></param>
       /// <param name="quant"></param>
       /// <returns></returns>
       /// <exception cref="Exception"></exception>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool DeleteAllProducts()
        {
            listProducts.Clear();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool DeleteProduct(Product p)
        {
            if (listProducts.Remove(p)) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NumProducts()
        {
            return listProducts.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
