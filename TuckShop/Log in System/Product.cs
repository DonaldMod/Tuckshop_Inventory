using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_in_System
{
    internal class Product
    {
        private string OrderIds;
        private string ProductName;
        private string Description; 
        private double Price;
        private int Quantity;
        private string CustomerName;
        private double Total;

        public Product()
        {
        }

        public Product(string orderIds, string productName, string description, double price, int quantity, string customerName, double total)
        {
            OrderID = orderIds;
            NameOfProduct = productName;
            DescriptionOfProduct = description;
            PriceOfProduct = price;
            ProductQuantity = quantity;
            NameOfCustomer = customerName;
            TotalAmount = total;
        }

        public string OrderID { get => OrderIds; set => OrderIds = value; }
        public string NameOfProduct { get => ProductName; set => ProductName = value; }
        public string DescriptionOfProduct { get => Description; set => Description = value; }
        public double PriceOfProduct { get => Price; set => Price = value; }
        public int ProductQuantity { get => Quantity; set => Quantity = value; }
        public string NameOfCustomer { get => CustomerName; set => CustomerName = value; }
        public double TotalAmount { get => Total; set => Total = value; }

    }
}
