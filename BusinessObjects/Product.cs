namespace BusinessObjects
{
    /// <summary>
    /// Represents a product.
    /// </summary>
    public class Product
    {
        #region Attributes

        private int id;
        private string name;
        private string description;
        private float price;
        private int quantity;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Product class with default values.
        /// </summary>
        public Product()
        {
            this.id = 0;
            this.name = string.Empty;
            this.description = string.Empty;
            this.price = 0.0f;
            this.quantity = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        public Product(int id, string name, string description, float price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name
        {
            set => name = value;
            get { return name; }
        }

        /// <summary>
        /// Gets or sets the description of the product
        /// </summary>
        public string Description
        {
            set => description = value;
            get { return description; }
        }

        /// <summary>
        /// Gets or sets the unique identifier of the product.
        /// </summary>
        public int Id
        {
            set => id = value;
            get { return id; }
        }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public float Price
        {
            set => price = value;
            get { return price; }
        }

        /// <summary>
        /// Gets or sets the quantity of the product.
        /// </summary>
        public int Quantity
        {
            set => quantity = value;
            get { return quantity; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator == (Product a, Product b)
        {
            if (a.id == b.id)
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator != (Product a, Product b)
        {
            return (!(a == b));
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the administrator's information.
        /// </summary>
        /// <returns>A string containing the administrator's information.</returns>
        public override string ToString()
        {
            return ProductInfo();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Product)
            {
                Product p = (Product)obj;
                if (this == p)
                    return true;
            }
            return false;
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Retrieves a string representation of the administrator's information.
        /// </summary>
        /// <returns>A formatted string containing the administrator's information.</returns>
        public string ProductInfo()
        {
            return string.Format("Product ID: {0}, Product Name: {1}, Description: {2}, Price: {3}, Quantity: {4}", 
              id , name, description, price, quantity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int CompareTo(Admin a)
        {
            if (a is null) return 1;
            else return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion
    }
}
