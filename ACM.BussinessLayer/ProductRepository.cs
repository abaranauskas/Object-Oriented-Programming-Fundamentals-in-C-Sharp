using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BussinessLayer
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            Object myObject = new Object();
            Console.WriteLine("Object " + myObject.ToString());
            Console.WriteLine("Product " + product.ToString());

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Delicious sunflowers";
                product.CurrentPrice = 15.99M;
            }

            return product;
        }


        public bool Save(Product product)
        {
            bool success = true;
            if (product.IsValid && product.HasChanges)
            {
                if (product.IsNew)
                {
                    //Call Insert procedura
                } else
                {
                    //update
                }
            }
            return success;

        }

    }
}
