using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IAdmins
    {
        bool AuthenticateAdmin(string email, string password, int key);
        List<Admin> GetAllAdmins();
        bool ExistAdmin(string email, int key);
        bool InsertAdmin(Admin a);
        bool UpdateAdminCredentials(Admin a, string name, string email, string pass);
        bool DeleteAllAdmins();
        bool DeleteAdmin(Admin a);
        int NumAdmins();
        bool ReadAdminsFile(string filename);
        bool SaveAdminsFile(string filename);
    }
}
