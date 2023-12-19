using BusinessObjects;
using System.Runtime.Serialization.Formatters.Binary;

namespace Data
{
    /// <summary>
    /// Representes the ShoppingCart
    /// </summary>
    public class ShoppingCarts
    {
        #region Attributes

        private static List<ShoppingCart> listShoppingCarts;

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        static ShoppingCarts()
        {
            listShoppingCarts = new List<ShoppingCart>();    
        }

        /// <summary>
        /// 
        /// </summary>
        public ShoppingCarts()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<ShoppingCart> ListShoppingCarts { get { return listShoppingCarts; } }

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
        public static List<ShoppingCart> getAllShoppingCarts()
        {
            return new List<ShoppingCart>(listShoppingCarts);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool DeleteAllShopingCarts()
        {
            listShoppingCarts.Clear();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool DeleteShoppingCart(ShoppingCart s)
        {
            if (listShoppingCarts.Remove(s)) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NumCarts()
        {
            return listShoppingCarts.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool ReadShoppingCartsFile(string filename)
        {
            try
            {
                if (!File.Exists(filename)) return false;
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listShoppingCarts);
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
        public static bool SaveShoppingCartsFile(string filename)
        {
            try
            {
                Stream stream;
                using (stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(stream, listShoppingCarts);
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
