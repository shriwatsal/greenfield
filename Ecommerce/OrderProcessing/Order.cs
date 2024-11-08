using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime timedate { get; set; }

        public int amount {  get; set; }

        public string status { get; set; }


    }
}
