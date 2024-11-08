using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
using Specification;
using BinaryDataRepositoryLib;

namespace Services
{
    public class ProductService : iProductService
    {

        public bool Seeding()
        {
            // Sample Data
            bool status = false;

            List<Product> products = new List<Product>();
            
              products.Add(new Product { Id = 1, Title = "Jasmine", Description = "Fragnance", Unitprice = 32, Quantity = 30, Image = "/images/Jasmine.jpg" });
              products.Add(new Product { Id = 2, Title = "Rose", Description = "Love", Unitprice = 12, Quantity = 80, Image = "/images/Rose.jpg" });
              products.Add(new Product { Id = 4, Title = "Lotus", Description = "Worship", Unitprice = 40, Quantity = 70, Image = "/images/Lotus.jpg" });
              products.Add(new Product { Id = 1, Title = "Lily", Description = "Beautiful", Unitprice = 20, Quantity = 100, Image = "/images/Lily.jpg" });
            IDataRepository repo = new BinaryDataRepository();
            repo.Serialize("products.dat", products);

            return status;

        }


        private List<Product> productslist;

        public ProductService()
        {
            productslist = new List<Product>();
        }

        public bool Delete(int id)
        {

            Product theProduct = Get(id);

            if(theProduct!=null)
            {
                List<Product> allproducts = GetAll();
                allproducts.Remove(theProduct);
                IDataRepository repo = new BinaryDataRepository();
                repo.Serialize("products.dat",allproducts);

                return true;


            }
            return false;
            /*Product theproduct =this.Get(id);
            this.productslist.Remove(theproduct);
            return true;
           // throw new NotImplementedException();*/
        }

        public Product Get(int id)
        {
            Product foundProduct = null;
            List<Product> products = GetAll();
            foreach(Product p in products)
            { if(p.Id==id) { foundProduct = p; }
                
                    }
            return foundProduct;

            //throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
          //Deserialization
            List<Product> products = new List<Product>();
            IDataRepository repository= new BinaryDataRepository();
            products = repository.Deserialize("products.dat");
          /*  products.Add(new Product { Id = 1, Title = "Jasmine", Description = "Fragnance", Unitprice = 32, Quantity = 30, Image = "/images/Jasmine.jpg" });
            products.Add(new Product { Id = 2, Title = "Rose", Description = "Love", Unitprice = 12, Quantity = 80, Image = "/images/Rose.jpg" });
            products.Add(new Product { Id = 4, Title = "Lotus", Description = "Worship", Unitprice = 40, Quantity = 70, Image = "/images/Lotus.jpg" });
            products.Add(new Product { Id = 1, Title = "Lily", Description = "Beautiful", Unitprice = 20, Quantity = 100, Image = "/images/Lily.jpg" });
           */ 
            return products;
            //throw new NotImplementedException();
        }

        public bool insert(Product product)
        {
            this.productslist.Add(product);
            return true;
            //throw new NotImplementedException();
        }

        public bool update(Product product)
        {
            Product theproduct=this.Get(product.Id);
            theproduct.Title = product.Title;
            theproduct.Description = product.Description;
            theproduct.Unitprice    = product.Unitprice;
            theproduct.Quantity = product.Quantity;
            return true;
           // throw new NotImplementedException();
        }
    }
}
