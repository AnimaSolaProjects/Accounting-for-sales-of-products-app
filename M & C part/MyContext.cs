using M___C_part.Produckt_s_model;
using System.Data.Entity;

namespace M___C_part.User_s_model
{
    public class MyContext : DbContext
    {
        public MyContext() : base("Connection")
        { }
        public DbSet<Grain> grains { get; set; }

        public DbSet<Product> products { get; set; }
    }
}
