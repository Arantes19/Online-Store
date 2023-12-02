using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Product
{
    public class Products
    {
        #region Attributes

        const int MAXPRODUCTS = 200;
        Product[] products;
        private int numProducts;

        #endregion

        #region Methods

        #region Constructors

        public Products() 
        {
            products = new Product[MAXPRODUCTS];
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets an array containing all products in the collection.
        /// </summary>
        public Product[] AllProducts
        {
            get { return products; }
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Initializes the product array by creating new Product objects.
        /// </summary>
        /// <param name="products">The array to be initialized.</param>
        void InitializeArrayProduct(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i] = new Product();
            }
        }

        /// <summary>
        /// Adds an product to the collection if it doesn't already exist and the maximum limit is not reached.
        /// </summary>
        /// <param name="product">The product to be added.</param>
        /// <returns>True if the product is added successfully, false otherwise.</returns>
        public bool AddProduct(Product product)
        {
            foreach (Product p in products)
            {
                if (p.Id == 0)
                    continue;
                if (p.Equals(product) || (numProducts >= MAXPRODUCTS))
                    return false;
            }
            products[numProducts] = product;
            numProducts++;
            return true;
        }

        /// <summary>
        /// Deletes all products in the collection by creating new product objects.
        /// </summary>
        /// <returns>True if deletion is successful, false otherwise.</returns>
        public bool DeleteAllProducts()
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Id is 0) continue;
                else products[i] = new Product();
            }
            return true;
        }

        /// <summary>
        /// Deletes a specific product from the collection.
        /// </summary>
        /// <param name="p">The product to be deleted.</param>
        /// <returns>True if the product is deleted successfully, false otherwise.</returns>
        public bool DeleteProduct(Product p)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(p))
                {
                    for (int j = i; j < products.Length; j++)
                    products[j] = products[j + i];
                    products[products.Length - 1] = new Product();
                    return true;
                }
            }
            return false;
        }

        #endregion

        #endregion
    }
}
