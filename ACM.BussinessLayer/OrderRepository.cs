using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BussinessLayer
{
    public class OrderRepository
    {
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            if (orderId ==10)
            {
                orderDisplay.FirstName = "Aidas";
                orderDisplay.LastName = "Baranauskas";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 5, 1, 8, 6, 32, 545,
                                 new TimeSpan(1, 0, 0));
                orderDisplay.ShippingAdress = new Address()
                {
                    StreetLine1 = "1501 truman ave.",
                    StreetLine2 = "",
                    City = "Key west",
                    StateProv = "FL",
                    PostalCode = "33030",
                    Country = "US",
                    AddressType = 1
                };

            }

            orderDisplay.orderDisplayList = new List<OrderDisplayItem>();

            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchachePrice = 15.99M,
                    OrderQuantity = 3
                };
                orderDisplay.orderDisplayList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchachePrice = 1.99M,
                    OrderQuantity = 2
                };
                orderDisplay.orderDisplayList.Add(orderDisplayItem);

            }

            return orderDisplay;
        }



        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId==10)
            {
                order.OrderDate = new DateTimeOffset(2008, 5, 1, 8, 6, 32, 545,
                                 new TimeSpan(1, 0, 0));
                
            }

            return order;
        }

        public bool Save(Order order)
        {
            bool success = true;
            if (order.IsValid && order.HasChanges)
            {
                if (order.IsNew)
                {
                    //Call Insert procedura
                }
                else
                {
                    //update
                }
            }
            return success;

        }

    }
}
