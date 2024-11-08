using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Specification;
using POCO;
namespace BinaryDataRepositoryLib
{
    public class BinaryDataRepository:IDataRepository
    {
        public bool Serialize(string filename,List<Product>products)
        {
            bool status = false;

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            formatter.Serialize(stream,products);
            stream.Close();

            return status;
        }

        public List<Product> Deserialize(string filename) {
            List<Product> products = new List<Product>();
            FileStream stream=new FileStream(filename, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            if(stream!=null)
            {
                products=(List<Product>)formatter.Deserialize(stream);
            }
            stream.Close();

            return products;

}
    }
}
