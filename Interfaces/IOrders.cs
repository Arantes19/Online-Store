using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOrders
    {
        List<Order> GetAllOrders();
        bool ExistOrder(int id);
        bool DeleteOrders();
        bool DeleteOrderById(int id);
        bool ReadOrdersFile(string filename);
        bool SaveOrdersFile(string filename);
    }
}
