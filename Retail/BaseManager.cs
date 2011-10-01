using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MUDIDemo.Data;

namespace MUDIDemo.Retail
{
	public abstract class BaseManager
	{
		private IDataProvider dataProvider;

		internal protected BaseManager(IDataProvider provider)
		{
			dataProvider = provider;	
		}

		internal protected IDataProvider DataProvider
		{
			get
			{
				return dataProvider ?? new DataProvider();
			}
		}
	}
}
