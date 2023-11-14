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

        private string name;
        private string address;
        private int zipCode;
        private int phoneNumber;
        private int nif;
        private static int numCostumers = 0;

        #endregion

        #region Methods

        #region Constructors

        static Costumer() => numCostumers = 0;

        public Costumer() 
        {
            email = string.Empty;
            password = string.Empty;
            name = string.Empty;
            address = string.Empty; 
            zipCode = 0;
            phoneNumber = 0;
            nif = 0;
        }

        public Costumer(string name, string email, string password) : base(email, password) => this.name = name;

        public Costumer(string address, int zipCode, int phoneNumber, int nif) 
        {
            this.address = address;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.nif = nif;
        }

        #endregion

        #region Properties

        public string UserName
        {
            set => this.name = value;
            get { return this.name; }
        }

        public string Address
        {
            set => this.address = value;
            get { return this.address; }
        }

        public int ZipCode
        {
        set 
        { 
             if (value > 0)
             this.zipCode = value; 
        }
            get { return this.zipCode; }
        }

        public int PhoneNumber
        {
            set
            {
                if (value > 0)
                this.phoneNumber = value;
            }
            get { return this.phoneNumber; }
        }

        public int Nif
        {
            set
            {
                if (value > 0)
                this.nif = value;
            }
            get { return this.nif; }
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return CostumerInfo();
        }

        public override bool Equals(object? obj)
        {
            if(obj is Costumer)
            {
                Costumer c = (Costumer)obj;
                if(this == c)
                    return true;
            }
            return false;
        }

        #endregion

        #region OtherMethods

        public string CostumerInfo()
        {
            return string.Format("Name: {0}, Email: {1}, Password: {2}, Address: {3}, ZipCode: {4}, PhoneNumber: {5}, NIF: {6}", name, email, password, address, zipCode, phoneNumber, nif);
        }

        public bool ExistCostumer(Costumer[] costumers, int nif)
        {
            foreach (Costumer c in costumers)
                if (c.nif == nif) return true;
            return false;
        }

        #endregion

        #endregion
    }
}
