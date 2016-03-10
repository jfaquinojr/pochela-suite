using Pochela.Infrastructure;
using Pochela.Inventory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Dapper;
using DapperExtensions;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Pochela.Inventory.Query.Mapper;

namespace Pochela.Inventory.Query
{
	public class ProductQuery : IQueryRepository<Product>
	{
		IConnectionFactory _connectionFactory;
		public ProductQuery()
		{
			_connectionFactory = new SqlConnectionFactory(ConfigurationManager.ConnectionStrings["pochela"].ConnectionString);
			DapperExtensions.DapperExtensions.DefaultMapper = typeof(ProductionSchemaMapper<>);
		}
		public ProductQuery(IConnectionFactory connectionFactory)
		{
			_connectionFactory = connectionFactory;
		}

		public string ConnectionManager { get; private set; }

		public Product GetById<TKey>(TKey Id)
		{
			Product ret;
			using(var cn = _connectionFactory.CreateConnection())
			{
				cn.Open();
				ret = cn.Get<Product>(Id);
				cn.Close();
			}
			return ret;
		}

		public IEnumerable<Product> Search(string filter)
		{
			IEnumerable<Product> list;
			using (var cn = _connectionFactory.CreateConnection())
			{
				cn.Open();
				list = Dapper.SqlMapper.Query<Product>(cn, "select ProductID,Name,ProductNumber,MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode,WeightUnitMeasureCode,Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryID,ProductModelID,SellStartDate,SellEndDate,DiscontinuedDate,cast(rowguid as varchar(100)) rowguid,ModifiedDate from production.product");
				cn.Close();
			}
			return list;
		}
	}
}
