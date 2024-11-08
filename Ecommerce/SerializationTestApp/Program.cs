using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;

namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService svc= new ProductService();
            svc.Seeding();

            List<Product> allproducts = svc.GetAll();

            foreach(Product product in allproducts)
            {
                Console.WriteLine(product.Id + " " + product.Unitprice);
            }
            Console.ReadLine();

        }
    }
}
