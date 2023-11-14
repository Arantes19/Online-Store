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

        const int MAXUSERS = 105;
        User[] users;
        private int numUsers;
    
        #endregion

        #region Methods

        #region Constructors

        public Users()
        {
       
            users = new User[MAXUSERS];
            InitializeArrayUsers(users);
        }

        #endregion

        #region Properties

        public User[] AllUsers
        {
            get { return users; }
        }

        #endregion

        #region OtherMethods

        void InitializeArrayUsers(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new User();

            }
        }

        public bool AddUser(User user)
        {
            foreach (User u in users)
            {
                if (u.Equals(user) || (numUsers >= MAXUSERS))
                    return false;
                else continue;
            }
            users[numUsers] = user;
            numUsers++;
            return true;
        }


        public bool DeleteAllUsers()
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] is null) continue;
                else users[i] = new User();
            }
            return true;
        }


        public bool DeleteUser(User u)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Equals(u))
                {
                    for (int j = i; j < users.Length; j++)
                        users[j] = users[j + i];
                    users[users.Length - 1] = new User();
                    return true;
                }
            }
            return false;
        }
        #endregion

        #endregion
    }
}