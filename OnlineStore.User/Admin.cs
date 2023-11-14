using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineStore.User
{
    public class Admin : User
    {
        #region Attributes

        private string adminUsername;
        private int adminKey;
        private static int numAdmin = 0;

        #endregion

        #region Methods

        #region Constructors

        static Admin() => numAdmin = 0;

        public Admin()
        {
            email = string.Empty;
            password = string.Empty;
            adminUsername = string.Empty;
            adminKey = 0;
        }

        public Admin(string email, string password, int key) : base(email, password)
        {
            this.adminKey = key;
        }

        public Admin(string username, string email, string password, int key) : base(email, password)
        {
            this.adminUsername = username;
            this.adminKey = key;
        }

        #endregion

        #region Properties

        public string AdminUsername
        {
            set => adminUsername = value;
            get { return adminUsername; }
        }

        public int AdminKey
        {
            set
            {
                if (value < 12)
                   adminKey = value;
            }
            get { return adminKey; }
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return AdminInfo();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Admin)
            {
                Admin a = (Admin)obj;
                if (this == a)
                    return true;
            }
            return false;
        }

        #endregion


        #region OtherMethods

        public string AdminInfo()
        {
            return string.Format("Name: {0}, Email: {1}, Password: {2}, Key: {3}", adminUsername, email, password, adminKey);
        }

        public bool ExistAdmin(Admin[] admins, int key)
        {
            foreach (Admin a in admins)
                if (a.AdminKey == key) return true;
            return false;
        }

        #endregion

        #endregion
    }
}
