using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    [Serializable]  // Added Metadata for giving info 
    public class Product
    {


        //We are using this class for Entities
        // poco -plain old clr object

        
        public int Id { get; set; }//auto property

        public string Title { get; set; }

        public int Unitprice { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

    }
}
