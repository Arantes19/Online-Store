using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IShoppingCarts
    {
        List<ShoppingCart> getAllShoppingCarts();
        bool ExistShoppingCart(ShoppingCart s);
        bool DeleteAllShopingCarts();
        bool DeleteShoppingCart(int id);
        int NumCarts();
        bool ReadShoppingCartsFile(string filename);
        bool SaveShoppingCartsFile(string filename);

    }
}
