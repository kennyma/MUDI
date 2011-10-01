using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MUDIDemo.Data.Entity;

namespace MUDIDemo.Data
{
	public partial class DataProvider : IDataProvider
	{
		public ProductType GetProductType(int productTypeID)
		{
			return new ProductType {ProductTypeID = 999, ProductTypeName = "Product Type 1"};
		}

		public ProductType SaveProductType(ProductType productType)
		{
			productType.ProductTypeID = 999;
			return productType;
		}

		public bool DeleteProductType(int productID)
		{
			return true;
		}
	}
}
