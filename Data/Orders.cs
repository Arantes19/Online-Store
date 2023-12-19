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
        /// 
        /// </summary>
        static Orders()
        {
            listOrders = new List<Order>();
        }

        /// <summary>
        /// 
        /// </summary>
        public Orders()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<Order> OrdersList { get { return listOrders; } }

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
        public static List<Order> GetAllOrders()
        {
            return new List<Order>(listOrders);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
