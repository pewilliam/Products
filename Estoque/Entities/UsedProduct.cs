using System;
using System.Globalization;

namespace Estoque.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufatureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) - R$ " + Price + " (Manufacture date: " + ManufatureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
