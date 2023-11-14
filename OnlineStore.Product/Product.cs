using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Product
{
    public class Product
    {
        #region Attributes

        private int id;
        private string name;
        private string description;
        private int price;
        private int quantity;
        private static int numProducts = 0;

        #endregion

        #region Methods

        #region Constructors

        static Product() => numProducts = 0;

        public Product()
        {
            id = 0;
            name = string.Empty;
            description = string.Empty;
            price = 0;
            quantity = 0;
        }

        #endregion

        #region Properties

        public string Name
        {
            set => name = value;
            get { return name; }
        }

        public string Description
        {
            set => description = value;
            get { return description; }
        }

        public int Id
        {
            set => id = value;
            get { return id; }
        }

        public int Price
        {
            set => price = value;
            get { return price; }
        }

        public int Quantity
        {
            set => quantity = value;
            get { return quantity; }
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #endregion
    }
}
