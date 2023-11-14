using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.User
{
    public class Admins
    {
        #region Attributes

        const int MAXADMINS = 5;
        Admin[] admins;
        private int numAdmins;

        #endregion


        #region Methods

        #region Constructors

        public Admins()
        {
            admins = new Admin[MAXADMINS];
            InitializeArrayAdmin(admins);
        }


        #endregion

        #region Properties

        public Admin[] AllAdmins
        {
            get { return admins; }
        }

        #endregion


        #region OtherMethods

        void InitializeArrayAdmin(Admin[] admins)
        {
            for (int i = 0; i < admins.Length; i++)
            {
                admins[i] = new Admin();

            }
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

        public bool DeleteAllAdmins()
        {
            for (int i = 0; i < admins.Length; i++)
            {
                if (admins[i].AdminKey is 0) continue;
                else admins[i] = new Admin();
            }
            return true;
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
