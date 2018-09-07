using Acme.Comon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BussinessLayer
{
    public class Order : EntityBase, ILoggable
    {
        public Order():this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            orderItems = new List<OrderItem>();
        }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> orderItems { get; set; }
        

        public override bool Validate()
        {
            bool result = true;

            if (OrderDate == null) { result = false; }
            return result;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date +" ("+OrderId+")";
        }

        public string Log()
        {
            string logString = this.OrderId + ": "+ "Date: " + 
                this.OrderDate.Value.Date + " " + "Status: " +
                this.EntityState.ToString();

            return logString;
        }
    }
}
