using M___C_part.Models;
using M___C_part.Produckt_s_model;
using System.Data.Entity;

namespace M___C_part.User_s_model
{
    public class Context : DbContext
    {
        public Context() : base("Connection")
        { }

        public DbSet<User> users { get; set; }

        public DbSet<Grain> grains { get; set; }

        public DbSet<Product> products { get; set; }
    }
}
