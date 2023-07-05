using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M___C_part.Produckt_s_model
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductType { get; set; }

        public int Amount { get; set; }

        public float Price { get; set; }

        public virtual Grain Grain { get; set; }

        public Product(string productType, int amount, float price, Grain grain)
        {
            ProductType = productType;
            Amount = amount;
            Price = price;
            Grain = grain;
        }
    }
}
