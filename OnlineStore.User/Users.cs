using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.User
{
    public class Users
    {
        #region Attributes

        const int MAXADMINS = 5;
        const int MAXCOSTUMERS = 100;
        private int numCostumers;
        Costumer[] costumers;
        Admin[] admins;
        private int numAdmins;
        #endregion

        #region Methods

        #region Constructors

        public Users()
        {
            costumers = new Costumer[MAXCOSTUMERS];
            admins = new Admin[MAXCOSTUMERS];
            InitializeArrayCostumers(costumers);
            InitializeArrayAdmin(admins);
        }

        #region OtherMethods

        void InitializeArrayCostumers(Costumer[] costumers)
        {
            for(int i = 0; i < costumers.Length; i++)
            {
                costumers[i] = new Costumer();
                
            }
        }

        void InitializeArrayAdmin(Admin[] admins)
        {
            for (int i = 0; i < admins.Length; i++)
            {
                admins[i] = new Admin();

            }
        }


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

        public bool AddAdmin(Admin admin)
        {
            foreach (Admin a in admins)
            {
                if (a.AdminKey == 0)
                    continue;
                if (a.Equals(admin) || (numAdmins >= MAXADMINS))
                    return false;
            }
            admins[numAdmins] = admin;
            numAdmins++;
            return true;
        }


        public bool DeleteAllCostumers()
        {
            for (int i = 0;i < costumers.Length;i++)
            {
                if (costumers[i].Nif is 0) continue;
                else costumers[i] = new Costumer();
            }
            return true;
        }

        public bool DeleteAllAdmins()
        {
            for (int i = 0; i < admins.Length; i++)
            {
                if (admins[i].AdminKey is 0) continue;
                else admins[i] = new Admin();
            }
            return true;
        }


        public bool DeleteCostumer(Costumer c)
        {
            for(int i = 0; i < costumers.Length; i++)
            {
                if (costumers[i].Equals(c))
                {
                    for(int j = i;  j < costumers.Length; j++)
                        costumers[j] = costumers[j + i];
                    costumers[costumers.Length - 1] = new Costumer();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteAdmin(Admin a)
        {
            for (int i = 0; i < admins.Length; i++)
            {
                if (admins[i].Equals(a))
                {
                    for (int j = i; j < admins.Length; j++)
                        admins[j] = admins[j + i];
                    admins[admins.Length - 1] = new Admin();
                    return true;
                }
            }
            return false;
        }
        #endregion

        #endregion
    }
}
