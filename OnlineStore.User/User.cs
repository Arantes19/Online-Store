using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.User
{
    public class User
    {
        #region Attributes

        string email;
        string password;
        private bool isAdmin;
        private bool isEmailConfirmed;
        private bool isCostumer;

        #endregion

        #region Methods

        #region Constructors

        public User() { }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        #endregion

        #region Properties

        public string Email
        {
            set => email = value;
            get { return email; }
        }

        public string Password
        {
            set => password = value;
            get { return password; }
        }

        #endregion

        #region Overrides

        #endregion

        #region OtherMethods

        #endregion

        #region Destructor

        ~User() { }

        #endregion

        #endregion
    }
}