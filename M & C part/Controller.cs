using M___C_part.Models;
using M___C_part.Produckt_s_model;
using M___C_part.User_s_model;
using System;
using System.Linq;

namespace M___C_part
{
    public class Controller
    {
        public Context context = new Context();
        public bool Registration(string login, string password, bool acces) 
        { 
            DateTime dateTime = DateTime.Now;
            User user = new User(login, password, dateTime, acces);
            
            context.users.Add(user);

            context.SaveChanges();
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public User Login(string login, string password)
        {
            User user = (from us in context.users where us.Login == login select us).FirstOrDefault();
            if (user != null)
            {
                if (user.Password == password)
                {
                    return user;       
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void ProductsAdd(string type, int amount, float price, string GrainType) 
        {
            Grain grain = (from gr in context.grains where gr.GrainType == GrainType select gr).FirstOrDefault();

            Product product = new Product(type, amount, price, grain);

            context.products.Add(product);
        }
        
        public void ProductsDelete(string type) 
        { 
            Product product = (from pr in context.products where pr.ProductType == type select pr).FirstOrDefault();
            context.products.Remove(product);
        }

        public void ProductsEdit(string type, int amount, float price, string edittype) 
        { 
            Product product = (from pr in context.products where pr.ProductType == type select pr).FirstOrDefault();
            switch (edittype)
            {
                case "type":
                    product.ProductType = type;
                    context.SaveChanges();
                    break;
                case "amount":
                    product.Amount = amount;
                    context.SaveChanges();
                    break;
                case "price":
                    product.Price = price;
                    context.SaveChanges();
                    break;
            }
            
        }

        public void GrainAdd(string type, double amount, float price)
        {
            Grain grain = new Grain(type, amount, price);
            
            context.grains.Add(grain);
            context.SaveChanges();
        }

        public void GrainDelete(string type) 
        {
            Grain grain = (from pr in context.grains where pr.GrainType == type select pr).FirstOrDefault();
            context.grains.Remove(grain);
        }

        public void GrainEdit(string type, int amount, float price, string edittype) 
        {
            Grain grain = (from pr in context.grains where pr.GrainType == type select pr).FirstOrDefault();
            switch (edittype)
            {
                case "type":
                    grain.GrainType = type;
                    context.SaveChanges();
                    break;
                case "amount":
                    grain.Amount = amount;
                    context.SaveChanges();
                    break;
                case "price":
                    grain.Price = price;
                    context.SaveChanges();
                    break;
                default:

                    break;
            }
        }
    }
}
