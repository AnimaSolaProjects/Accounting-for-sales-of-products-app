using System.Collections.Generic;

namespace M___C_part.Produckt_s_model
{
    public class Grain
    {
        public int Id { get; set; }

        public string GrainType { get; set; }

        public double Amount { get; set; }

        public float Price { get; set; }

        public virtual ICollection<Product> Products { get; set;}

        public Grain(string grainType, double amount, float price)
        {
            GrainType = grainType;
            Amount = amount;
            Price = price;
        }
    }
}
