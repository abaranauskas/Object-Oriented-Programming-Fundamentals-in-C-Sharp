using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;
using Acme.Comon;

namespace ACM.BussinessLayer
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;             
        }
        

        public int ProductId { get; private set; }
        //public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Decimal? CurrentPrice { get; set; }

        private string _productName;

        public string ProductName
        {
            get {
                //return StringHandler.InsertSpaces(_productName);
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }


        public override bool Validate()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(ProductName)) { result = false; }
            if (CurrentPrice == null) { result = false; }

            return result;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            string logString = this.ProductId + ": " + this.ProductName +
                " " + "Details: " + this.ProductDescription + " " + "Status: " +
                this.EntityState.ToString();

            return logString;
        }
    }
}
