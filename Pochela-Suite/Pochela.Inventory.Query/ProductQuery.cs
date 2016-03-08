using Pochela.Infrastructure;
using Pochela.Inventory.Query.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Dapper;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Pochela.Inventory.Query
{
	public class ProductQuery : IQueryRepository<Product>
	{
		IDbConnection _cn;
		public ProductQuery()
		{
			_cn = new SqlConnection(ConfigurationManager.ConnectionStrings["pochela"].ConnectionString);
		}
		public ProductQuery(IDbConnection cn)
		{
			_cn = cn;
		}

		public string ConnectionManager { get; private set; }

		public Product GetById<TKey>(TKey Id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Product> Search(Expression<Func<Product, bool>> criteria)
		{
			var products = SqlMapper.Query<Product>(_cn, "select ProductID, Name, ProductNumber, Color, SafetyStockLevel, StandardCost, ListPrice from production.product");

			return products;
		}
	}
}
