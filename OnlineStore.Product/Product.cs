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
        private UInt32 price;
        private UInt32 quantity;

        #endregion

        #region Methods

        #region Constructors
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

        public UInt32 Price
        {
            set => price = value;
            get { return price; }
        }

        public UInt32 Quantity
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
