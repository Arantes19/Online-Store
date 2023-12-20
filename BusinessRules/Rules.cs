/*
*	<copyright file="Rules" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

using BusinessObjects;
using Data;
using static Exceptions.FileExceptions;

namespace BusinessRules
{
    /// <summary>
    /// Contains business rules and logic.
    /// </summary>
    public class Rules
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Rules class.
        /// </summary>
        public Rules() { }

        #endregion

        #region OtherMethods

        #region Users

        /// <summary>
        /// Inserts a user with error handling.
        /// </summary>
        /// <param name="u">The user to insert.</param>
        /// <returns>True if the user is inserted successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during user insertion.</exception>
        public static bool InsertUsersBR(User u)
        {
            if (u.Email == string.Empty || u.Password == string.Empty) return false;
            try
            {
                Users.InsertUser(u);
                return true;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Retrieves a list of all users with error handling.
        /// </summary>
        /// <returns>A copy of the list of all users if successful; otherwise, an empty list.</returns>
        public static List<User> GetAllUsersBR()
        {
            List<User> newList = new List<User>();
            try
            {
                Users userAux = new Users();

                foreach (User u in userAux.UsersList)
                {
                    if (!Users.IsEmailValid())
                    {
                        throw new Exception();
                    }
                    newList.Add(u);
                }
                return newList;
            }
            catch (Exception)
            {
                return new List<User>(); // Return an empty list on error
                throw new Exception();
            }
        }

        /// <summary>
        /// Saves user data to a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the data is saved successfully; otherwise, false.</returns>
        /// <exception cref="SaveFileException">Thrown if there is an exception during file saving.</exception>
        public static bool SaveUsersFileBR(string filename)
        {
            try
            {
                Users.SaveUsersFile(filename);
                return true;
            }
            catch (SaveFileException e)
            {
                throw new SaveFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }

        /// <summary>
        /// Reads user data from a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if the data is read successfully; otherwise, false.</returns>
        /// <exception cref="ReadFileException">Thrown if there is an exception during file reading.</exception>
        public static bool ReadUsersFileBR(string filename)
        {
            try
            {
                Users.ReadUsersFile(filename);
                return true;
            }
            catch (ReadFileException e)
            {
                throw new ReadFileException(e.Message + ": " + "Error Reading File!!!");
            }
        }

        #endregion

        #region Customers

        /// <summary>
        /// Inserts a new customer with the specified email.
        /// </summary>
        /// <param name="email">The email address of the customer.</param>
        /// <returns>True if the customer is inserted successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during customer insertion.</exception>
        public static bool InsertCustomer(string email)
        {
            try
            {
                Costumer aux = new Costumer();
                aux = Costumers.GetCostumerByEmail(email);

                if (aux is not null)
                {
                    throw new Exception();
                }
                Costumer newCustomer = new Costumer();
                Costumers.InsertCostumer(newCustomer);
                return true;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Adds a product to the customer's shopping cart.
        /// </summary>
        /// <param name="customer">The customer object.</param>
        /// <param name="email">The email address of the customer.</param>
        /// <param name="productId">The ID of the product to add to the cart.</param>
        /// <returns>True if the product is added to the cart successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during the process.</exception>
        public static bool AddProductToCart(Costumers customer, string email, int productId)
        {
            try
            {
                Costumer costumer = new Costumer();
                costumer = Costumers.GetCostumerByEmail(email);
                if (customer is null)
                {
                    throw new Exception("Customer not found.");
                }

                Product product = new Product();
                product = Products.ExistProduct(productId);
                if (product is null)
                {
                    throw new Exception();
                }

                if (costumer.PersonalCart != null)
                {
                    throw new Exception("Customer already has a shopping cart.");
                }
                ShoppingCart newCart = new ShoppingCart();
                newCart.AddProductToCart(product);
                costumer.PersonalCart = newCart;
                return true;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Adds balance to the customer's account.
        /// </summary>
        /// <param name="customer">The customer object.</param>
        /// <param name="value">The value to add to the balance.</param>
        /// <returns>True if the balance is added successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during the process.</exception>
        public static bool AddBalanceBR(Costumer customer, float value)
        {
            try
            {
                return Costumers.AddBalance(customer, value);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Saves customer data to a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the data is saved successfully; otherwise, false.</returns>
        /// <exception cref="SaveFileException">Thrown if there is an exception during file saving.</exception>
        public static bool SaveCustomersFileBR(string filename)
        {
            try
            {
                Costumers.SaveCostumersFile(filename);
                return true;
            }
            catch (SaveFileException e)
            {
                throw new SaveFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }

        /// <summary>
        /// Reads customer data from a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if the data is read successfully; otherwise, false.</returns>
        /// <exception cref="ReadFileException">Thrown if there is an exception during file reading.</exception>
        public static bool ReadCustomersFileBR(string filename)
        {
            try
            {
                Costumers.ReadCostumersFile(filename);
                return true;
            }
            catch (ReadFileException e)
            {
                throw new ReadFileException(e.Message + ": " + "Error Reading File!!!");
            }
        }

        #endregion

        #region Admins

        /// <summary>
        /// Saves admin data to a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the data is saved successfully; otherwise, false.</returns>
        /// <exception cref="SaveFileException">Thrown if there is an exception during file saving.</exception>
        public static bool SaveAdminsFileBR(string filename)
        {
            try
            {
                Admins.SaveAdminsFile(filename);
                return true;
            }
            catch (SaveFileException e)
            {
                throw new SaveFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }

        /// <summary>
        /// Reads admin data from a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if the data is read successfully; otherwise, false.</returns>
        /// <exception cref="ReadFileException">Thrown if there is an exception during file reading.</exception>
        public static bool ReadAdminsFileBR(string filename)
        {
            try
            {
                Admins.ReadAdminsFile(filename);
                return true;
            }
            catch (ReadFileException e)
            {
                throw new ReadFileException(e.Message + ": " + "Error Reading File!!!");
            }
        }

        #endregion

        #region Products

        /// <summary>
        /// Inserts a new product and verifies its validity with error handling.
        /// </summary>
        /// <param name="newProduct">The new product to be inserted.</param>
        /// <returns>True if the product is valid and inserted successfully; otherwise, false.</returns>
        /// <exception cref="Exception">Thrown if there is an exception during product insertion or validation.</exception>
        public static bool IsProductValidBR(Product newProduct)
        {
            try
            {
                Products.InsertProduct(newProduct);
                if (Products.VerifyProductId(newProduct.Id))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Saves product data to a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the data is saved successfully; otherwise, false.</returns>
        /// <exception cref="SaveFileException">Thrown if there is an exception during file saving.</exception>
        public static bool SaveProductsFileBR(string filename)
        {
            try
            {
                Products.SaveProductsFile(filename);
                return true;
            }
            catch (SaveFileException e)
            {
                throw new SaveFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }

        /// <summary>
        /// Reads product data from a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if the data is read successfully; otherwise, false.</returns>
        /// <exception cref="ReadFileException">Thrown if there is an exception during file reading.</exception>
        public static bool ReadProductsFileBR(string filename)
        {
            try
            {
                Products.ReadProductsFile(filename);
                return true;
            }
            catch (ReadFileException e)
            {
                throw new ReadFileException(e.Message + ": " + "Error Reading File!!!");
            }
        }

        #endregion

        #region Orders

        /// <summary>
        /// Saves order data to a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        /// <returns>True if the data is saved successfully; otherwise, false.</returns>
        /// <exception cref="SaveFileException">Thrown if there is an exception during file saving.</exception>
        public static bool SaveOrdersFileBR(string filename)
        {
            try
            {
                Orders.SaveOrdersFile(filename);
                return true;
            }
            catch (SaveFileException e)
            {
                throw new SaveFileException(e.Message + ": " + "Error Saving File!!!");
            }
        }

        /// <summary>
        /// Reads order data from a file with error handling.
        /// </summary>
        /// <param name="filename">The name of the file to read from.</param>
        /// <returns>True if the data is read successfully; otherwise, false.</returns>
        /// <exception cref="ReadFileException">Thrown if there is an exception during file reading.</exception>
        public static bool ReadOrdersFileBR(string filename)
        {
            try
            {
                Orders.ReadOrdersFile(filename);
                return true;
            }
            catch (ReadFileException e)
            {
                throw new ReadFileException(e.Message + ": " + "Error Reading File!!!");
            }
        }

        #endregion

        #endregion

        #endregion
    }
}