using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BussinessLayer
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int OrderitemId)
        {
            OrderItemId = OrderItemId;
        }

        public int OrderItemId { get; private set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchacePrice { get; set; }
        
        public OrderItem Retrieve()
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool result = true;
            if (PurchacePrice == null) { result = false; }
            if (Quantity <= 0) { result = false; }
            if (ProductId <= 0) { result = false; }
            return result;
        }
    }
}
