/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

using OnlineStore.Data;

namespace OnlineStore.App
{
    /// <summary>
    /// Represents the Input and Output of the program.
    /// </summary>
    public class IO
    {
        public static bool Input()
        {
            // Testing Costumer class
            Costumer costumer1 = new Costumer("John Doe", "john@example.com", "password123");
            costumer1.Address = "123 Main St";
            costumer1.ZipCode = 4720794;
            costumer1.PhoneNumber = 987654321;
            costumer1.Nif = 123456789;

            Console.WriteLine("Costumer Information:");
            Console.WriteLine(costumer1.CostumerInfo());

            // Testing Costumers class
            Costumers costumersManager = new Costumers();

            // Adding a costumer
            bool addCostumerResult = costumersManager.AddCostumer(costumer1);
            Console.WriteLine($"\nAdd Costumer Result: {addCostumerResult}");

            // Displaying all costumers
            Console.WriteLine("\nAll Costumers:");
            foreach (Costumer c in costumersManager.AllCostumers)
            {
                Console.WriteLine(c);
            }

            // Deleting a costumer
            bool deleteCostumerResult = costumersManager.DeleteCostumer(costumer1);
            Console.WriteLine($"\nDelete Costumer Result: {deleteCostumerResult}");

            // Displaying all costumers after deletion
            Console.WriteLine("\nAll Costumers After Deletion:");
            foreach (Costumer c in costumersManager.AllCostumers)
            {
                Console.WriteLine(c);
            }
            return true;
        }

    }
}

