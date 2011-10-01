using System;
using System.Collections.Generic;
using Autofac;
using Autofac.Builder;
using MUDIDemo.Data;
using MUDIDemo.Data.Entity;
using MUDIDemo.Retail;
using NMock2;
using NUnit.Framework;

namespace MUDIDemo.Tests.Unit.RetailManagerTest
{
	[TestFixture]
	public class RetailManagerTest
	{
		private Mockery mockery;
		private IDataProvider mockDataProvider;
		private IContainer container;

		[TestFixtureSetUp]
		public void Setup()
		{
			mockery = new Mockery();
			mockDataProvider = mockery.NewMock<IDataProvider>();

			var builder = new ContainerBuilder();
			builder.Register(c => new RetailManager(mockDataProvider)).FactoryScoped();

			container = builder.Build();
		}

		[TestFixtureTearDown]
		public void Teardown()
		{			
			if (mockery != null)
				mockery.Dispose();

			if (container != null)
				container.Dispose();
		}

		[Test]
		public void GetProducts_ShouldReturnAllProducts()
		{
			Expect.Once.On(mockDataProvider).
			Method("GetProducts").
			Will(Return.Value(new List<Product>
				                  	{
				                  		new Product
			       						{
			       							ProductID = 990,
			       							Name = "Product A",
			       							CreateDate = DateTime.Now,
											ProductType = new ProductType
						              						{
						              							ProductTypeID = 999,
																ProductTypeName = "Product Type 1"
						              						}
			       						},
				                  		new Product
			       						{
			       							ProductID = 991,
			       							Name = "Product B",
			       							CreateDate = DateTime.Now,
											ProductType = new ProductType
						              						{
						              							ProductTypeID = 999,
																ProductTypeName = "Product Type 1"
						              						}

			       						}
				                  	}));

			RetailManager manager = container.Resolve<RetailManager>();
			List<Product> products = manager.GetProducts();

			Assert.AreEqual(2, products.Count);
			mockery.VerifyAllExpectationsHaveBeenMet();
		}

		[Test]
		public void SaveProducts_ShouldReturnProdiuctID()
		{
			Product toSave = new Product
			                 	{
			                 		Name = "Product A",
			                 		CreateDate = DateTime.Now,
			                 		ProductType = new ProductType
			                 		              	{
			                 		              		ProductTypeName = "Product Type 1"
			                 		              	}

			                 	};

			Product expected = toSave;
			expected.ProductID = 999;
			expected.ProductType.ProductTypeID = 9998;

			Expect.Once.On(mockDataProvider).Method("SaveProduct").With(toSave).Will(Return.Value(expected));
			Expect.Once.On(mockDataProvider).Method("SaveProductType").With(toSave.ProductType).Will(Return.Value(expected.ProductType));

			RetailManager manager = container.Resolve<RetailManager>();
			Product result = manager.SaveProduct(toSave);

			Assert.AreEqual(expected.ProductID, result.ProductID);
			Assert.AreEqual(expected.Name, result.Name);
			Assert.AreEqual(expected.ProductType.ProductTypeID, result.ProductType.ProductTypeID);

			mockery.VerifyAllExpectationsHaveBeenMet();
		}
	}
}
