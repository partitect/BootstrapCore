using DbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBApp.Data
{
    public interface IData
    {
		//Product Interfaces
		Product GetProduct(int id);
		List<Product> GetAllProduct();

		//Customer Interfaces
		Customer GetCustomer(int id);
		List<Customer> GetAllCustomer();
	}
}
