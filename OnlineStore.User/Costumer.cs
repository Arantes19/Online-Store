using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.User
{
    public class Costumer : User
    {
        #region Atributes

        private string userName;
        private string address;
        private UInt32 zipCode;
        private UInt32 phoneNumber;
        private UInt32 nif;

        #endregion

        #region Methods

        #region Constructors

        public Costumer(string email, string password) : base(email, password)
        {
            this.Email = email;
            this.Password = password;
        }

        public Costumer(string userName, string address, uint zipCode, uint phoneNumber, uint nif) : this(userName, address)
        {
            this.userName = userName;
            this.address = address;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.nif = nif;
        }

        #endregion

        #region Properties

        public string UserName
        {
            set => this.userName = value;
            get { return this.userName; }
        }

        public string Address
        {
            set => this.address = value;
            get { return this.address; }
        }

        public UInt32 ZipCode
        {
            set => this.zipCode = value;
            get { return this.zipCode; }
        }

        public UInt32 PhoneNumber
        {
            set => this.phoneNumber = value;
            get { return this.phoneNumber; }
        }

        public UInt32 Nif
        {
            set => this.nif = value;
            get { return this.nif; }
        }

        #endregion

        #endregion
    }
}
