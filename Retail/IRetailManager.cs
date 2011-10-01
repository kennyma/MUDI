using System.Collections.Generic;
using MUDIDemo.Data.Entity;

namespace MUDIDemo.Retail
{
	public interface IRetailManager
	{
		List<Product> GetProducts();
		Product SaveProduct(Product product);
	}
}