using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MUDIDemo.Data;
using MUDIDemo.Data.Entity;

namespace MUDIDemo.Retail
{
	public class RetailManager : BaseManager, IRetailManager
	{		
		public RetailManager(IDataProvider provider) : base(provider){}

		public List<Product> GetProducts()
		{
			List<Product> products = DataProvider.GetProducts();
			return products;
		}

		public Product SaveProduct(Product product)
		{
			product = DataProvider.SaveProduct(product);
			product.ProductType = DataProvider.SaveProductType(product.ProductType);

			return product;
		}
	}
}
