using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderService : iOrderService
    {
        private List<Order> orderlist;

        public OrderService() { 
            orderlist = new List<Order>();
        }
        public bool Delete(int id)
        {
            Order theorder = this.Get(id);
            this.orderlist.Remove(theorder);
            return true;

            //throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            foreach(Order theorder in this.orderlist)
            {
                if(theorder.Id== id) return theorder;

            }
            return null;
            //throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            return this.orderlist;
            //throw new NotImplementedException();
        }

        public bool Insert(Order order)
        {
            orderlist.Add(order);
            return true;

            //throw new NotImplementedException();
        }

        public bool Update(Order order)
        {
            Order theorder=this.Get(order.Id);
            theorder.amount = order.amount;
            theorder.timedate = order.timedate;
            theorder.status = order.status;

            return true;


           // throw new NotImplementedException();
        }
    }
}
