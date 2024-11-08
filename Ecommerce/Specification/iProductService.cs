using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;

namespace Specification
{
    public interface iProductService
    {
        List<Product> GetAll();

        Product Get(int id);

        bool insert(Product product);

        bool update(Product product);

        bool Delete(int id);

    }
}
