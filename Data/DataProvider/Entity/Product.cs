using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MUDIDemo.Data.Entity
{
	public class Product
	{
		public int ProductID { get; set;}
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
		public ProductType ProductType { get; set; }
	}
}
