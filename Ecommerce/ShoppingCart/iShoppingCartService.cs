using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public interface iShoppingCartService
    {
        List<Item> GetItems();

        bool AddtoCart(Item item);
        bool RemovetoCart(Item item);

        bool Clear();

    }
}
