using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Represents a collection of customers.
    /// </summary>
    public class Costumers
    {
        #region Attributes

        static Dictionary<int, List<Costumer>> costumers;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Costumers() { }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static bool InsereUtente(Costumer c, int nif)
        {
            if (!costumers.ContainsKey(nif))
                costumers.Add(nif, new List<Costumer>());
            if (!costumers[nif].Contains(c))
            {
                costumers[nif].Add(c);
                return true;
            }
            return false;
        }

        /*
        /// <summary>
        /// Adds a customer to the collection if it doesn't already exist and the maximum limit is not reached.
        /// </summary>
        /// <param name="costumer">The customer to be added</param>
        /// <returns>True if the customer is added successfully, false otherwise.</returns>
        public bool AddCostumer(Costumer costumer)
        {
            foreach (Costumer c in costumers)
            {
                if (c.Nif == 0)
                    continue;
                if (c.Equals(costumer) || (numCostumers >= MAXCOSTUMERS))
                    return false;
            }
            costumers[numCostumers] = costumer;
            numCostumers++;
            return true;
        }

        /// <summary>
        /// Deletes all customers in the collection by creating new Costumer objects.
        /// </summary>
        /// <returns>True if deletion is successful, false otherwise.</returns>
        public bool DeleteAllCostumers()
        {
            for (int i = 0; i < costumers.Length; i++)
            {
                if (costumers[i].Nif is 0) continue;
                else costumers[i] = new Costumer();
            }
            return true;
        }

        /// <summary>
        /// Deletes a specific customer from the collection.
        /// </summary>
        /// <param name="c">The customer to be deleted.</param>
        /// <returns>True if the customer is deleted successfully, false otherwise.</returns>
        public bool DeleteCostumer(Costumer c)
        {
            for (int i = 0; i < numCostumers; i++)
            {
                if (costumers[i].Equals(c))
                {
                    for (int j = i; j < numCostumers - 1; j++)
                        costumers[j] = costumers[j + 1];
                    costumers[numCostumers - 1] = new Costumer();
                    numCostumers--;
                    return true;
                }
            }
            return false;
        }
        */

        #endregion

        #endregion
    }
}
