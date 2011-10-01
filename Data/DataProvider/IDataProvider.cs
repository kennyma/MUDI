using System.Collections.Generic;
using MUDIDemo.Data.Entity;

namespace MUDIDemo.Data
{
	public interface IDataProvider
	{
		Product GetProduct(int productID);
		Product SaveProduct(Product product);
		ProductType SaveProductType(ProductType productType);
		bool DeleteProductType(int productID);
		ProductType GetProductType(int productTypeID);
		List<Product> GetProducts();
	}
}