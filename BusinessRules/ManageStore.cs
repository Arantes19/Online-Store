using BusinessObjects;
using System.Reflection.Metadata;

namespace BusinessRules
{
    public class ManageStore
    {
        public static bool InsertUser(User u)
        {
            if (u == null) return false;
            else return true;
        }
    }
}