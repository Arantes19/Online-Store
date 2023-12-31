/*
*	<copyright file="IO" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using BusinessObjects;
using Data;
using BusinessRules;
using Exceptions;

namespace Aplication
{
    public class IO
    {
        public static bool Input()
        {
            #region BO
            
            //Creating random objects
            
            List<User> users = new List<User> 
            {
                new User("francisco@gmail.com", "francisco"),
                new User("miguel@gmail.com", "miguel"),
                new User("jose@gmail.com", "jose"),
            };

            List<Costumer> costumersList= new List<Costumer>
            {
                new Costumer(254140888, "costumer1", "amares", 4720794, 910121660, "costumer1@gmail.com", "costumer1", new ShoppingCart()),
                new Costumer(123456789, "costumer2", "braga", 4720342, 912321999, "costumer2@gmail.com", "costumer2", new ShoppingCart()),
                new Costumer(321312111, "costumer3", "porto", 5730882, 927831222, "costumer3@gmail.com", "costumer3", new ShoppingCart()),
            };

            Admin a0 = new Admin("admin1", "admin1@gmail.com", "adminum1", 922122);

            List<Product> productList = new List<Product>
            {
                 new Product(1, "Book1", "C", (float)9.99, 10),
                 new Product(2, "Book2", "C#", (float)12.34, 10),
                 new Product(3, "Book3", "JS", (float)14.99, 10),
                 new Product(4, "Book4", "Python", (float)12.34, 10),
                 new Product(5, "Book5", "C++", (float)14.99, 10),
                 new Product(6, "Book6", "Kotlin", (float)19.99, 10),
            };

            ShoppingCart sp0 = new ShoppingCart(1213112, 1, false, productList);

            Order o1 = new Order(1213112, 3, new DateOnly(2023, 1, 31), new DateOnly(2023, 2, 5), Order.OrderStatus.Processing);
            Order o2 = new Order(1423112, 2, new DateOnly(2023, 3, 3), new DateOnly(2023, 3, 10), Order.OrderStatus.Processing);
            Order o3 = new Order(1213112, 1, new DateOnly(2023, 4, 2), new DateOnly(2023, 5, 6), Order.OrderStatus.Processing);

            Payment pm0 = new Payment("Paypal", (float)13.99, new DateTime(2023, 1, 31, 9, 30, 30));

            #endregion

            #region Data

            //Testar a leitura de ficheiros
            try
            {
                bool aux = Rules.ReadUsersFileBR("users.txt");
                aux = Rules.ReadCustomersFileBR("costumers.txt");
                aux = Rules.ReadProductsFileBR("products.txt");
                aux = Rules.ReadAdminsFileBR("admins.txt");
            }
            catch (FileExceptions.ReadFileException e)
            {
                Console.WriteLine(e.Message);
            }
            
            #endregion


            return true;

        }
    }
}
