using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    
    public interface iCustomerService
    {
       List<Customer> GetAll(); // abstract method for interface

        Customer Get(int id);

        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);

    }
}
