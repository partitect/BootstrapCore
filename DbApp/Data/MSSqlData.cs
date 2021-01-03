using DbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBApp.Data
{
    public class MSSqlData:IData
    {
        dbaseContext db = new dbaseContext();


        public Product GetProduct(int id)
        {
            return db.Products.FirstOrDefault(f => f.Id == id);
        }

        public List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }

        public Customer GetCustomer(int id)
        {
            return db.Customers.FirstOrDefault(f => f.Id == id);
        }

        public List<Customer> GetAllCustomer()
        {
            return db.Customers.ToList();
        }
    }
}
