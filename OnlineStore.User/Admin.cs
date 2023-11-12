using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.User
{
    public class Admin : User
    {
        #region Attributes

        private string adminEmail;
        private string adminPassword;
        private string adminUsername;

        #endregion

        #region Methods

        #region Constructors

        public Admin()
        {
        }

        public Admin(string email, string password) : base(email, password)
        {
        }

        public Admin(string username, string email, string password) : base(email, password)
        {
            this.adminUsername = username;
        }

        #endregion

        #region Properties

        public string AdminUsername
        {
            set => adminUsername = value;
            get { return adminUsername; }
        }

        public string AdminEmail
        {
            set => adminEmail = value;
            get { return adminEmail; }
        }

        public string AdminPassword
        {
            set => adminPassword = value;
            get { return adminPassword; }
        }

        #endregion

        #region OtherMethods
        #endregion

        #region Destructor

        ~Admin() { }

        #endregion

        #endregion
    }
}
