/*
*	<copyright file="Tests" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using BusinessObjects;
using Data;

namespace Tests
{
    [TestClass]
    public class StoreTests
    {
        [TestMethod]
        public void InsertCostumer()
        {
            Costumer c1 = new Costumer(254140888, "costumer1", "amares", 4720794, 910121660, "costumer1@gmail.com", "costumer1", new ShoppingCart());
            Costumer c2 = new Costumer(123456789, "costumer2", "braga", 4720342, 912321999, "costumer2@gmail.com", "costumer2", new ShoppingCart());
            Costumer c3 = new Costumer(321312111, "costumer3", "porto", 5730882, 927831222, "costumer3@gmail.com", "costumer3", new ShoppingCart());
            Costumer c = c1;

            bool aux;
            try
            {
                aux = Costumers.InsertCostumer(c1);
                aux = Costumers.InsertCostumer(c2);
                aux = Costumers.InsertCostumer(c3);
                aux = Costumers.InsertCostumer(c); //error
            }
            catch (Exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void InsertProductInCart()
        {
            bool aux;
            try
            {
                List<Product> productList = new List<Product>
                {
                    new Product(1, "Book1", "C", (float)9.99, 10),
                    new Product(2, "Book2", "C#", (float)12.34, 10),
                    new Product(3, "Book3", "JS", (float)14.99, 10),
                };

                ShoppingCart sp1 = new ShoppingCart(1213112, 1, false, productList);

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}