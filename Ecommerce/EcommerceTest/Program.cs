using CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
using Catalog;
using OrderProcessing;

namespace EcommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Shri";



            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Raju";

            iCustomerService customerService = new CustomerService();
            customerService.Insert(customer1);
            customerService.Insert(customer2);

            List<Customer> customerlist = customerService.GetAll();
            foreach(Customer customer in customerlist)
            {
                Console.WriteLine(customer.FirstName);
            }
            



            Product product1= new Product();
            product1.Id = 1;
            product1.Description = "good";
            product1.Title = "Mobile";
            product1.Unitprice = 10;
            product1.Quantity = 100;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Unitprice = 20;
            product2.Quantity = 150;

            iProductService productService = new ProductService();
            productService.insert(product1);
            productService.insert(product2);

            List<Product> productlist = productService.GetAll();

            foreach(Product product in productlist)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Unitprice);
                Console.WriteLine(product.Quantity);
            }


            //Console.ReadLine();

            Order order1 = new Order();
            order1.Id = 1;
            order1.amount = 25;
            order1.timedate = DateTime.Now;

            Order order2 = new Order();
            order2.Id = 1;
            order2.amount = 25;
            order2.timedate = new DateTime(2024, 10, 25);

           iOrderService orderservice = new OrderService();
            orderservice.Insert(order1);
            orderservice.Insert(order2);

            List<Order> orderslist = orderservice.GetAll();
            foreach(Order order in orderslist)
            {
                Console.WriteLine(order.Id);
                Console.WriteLine(order.amount);
                Console.WriteLine(order.timedate);
               
            }


            Console.ReadLine();


        }
    }
}
