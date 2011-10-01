using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MUDIDemo.Data.Entity;

namespace MUDIDemo.Data
{
	public partial class DataProvider : IDataProvider
	{
		public List<Product> GetProducts()
		{
			List<Product> products = new List<Product>();
			products.Add(new Product
			       	{
			       		ProductID = 990,
			       		Name = "Product A",
			       		CreateDate = DateTime.Now,
						ProductType = new ProductType
						              	{
						              		ProductTypeID = 999,
											ProductTypeName = "Product Type 1"
						              	}

			       	});

			products.Add(new Product
			{
				ProductID = 991,
				Name = "Product A",
				CreateDate = DateTime.Now,
				ProductType = new ProductType
				{
					ProductTypeID = 999,
					ProductTypeName = "Product Type 1"
				}

			});

			products.Add(new Product
			{
				ProductID = 992,
				Name = "Product A",
				CreateDate = DateTime.Now,
				ProductType = new ProductType
				{
					ProductTypeID = 999,
					ProductTypeName = "Product Type 1"
				}

			});

			products.Add(new Product
			{
				ProductID = 993,
				Name = "Product A",
				CreateDate = DateTime.Now,
				ProductType = new ProductType
				{
					ProductTypeID = 999,
					ProductTypeName = "Product Type 1"
				}

			});

			products.Add(new Product
			{
				ProductID = 994,
				Name = "Product A",
				CreateDate = DateTime.Now,
				ProductType = new ProductType
				{
					ProductTypeID = 999,
					ProductTypeName = "Product Type 1"
				}

			});

			return products;
		}

		public Product GetProduct(int productID)
		{
			return new Product
			       	{
			       		ProductID = productID,
			       		Name = "Product A",
			       		CreateDate = DateTime.Now,
						ProductType = new ProductType
						              	{
						              		ProductTypeID = 999,
											ProductTypeName = "Product Type 1"
						              	}

			       	};
		}

		public Product SaveProduct(Product product)
		{
			product.ProductID = 999;
			return product;
		}

	}
}
