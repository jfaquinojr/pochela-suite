using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pochela.Infrastructure;
using Pochela.POS.Entities;
using Dapper;
using System.Configuration;

namespace Pochela.POS.Db
{
	public class QueryProducts : IQueryRepository<Product>
	{
		IConnectionFactory _connectionFactory;

		public QueryProducts()
		{
			_connectionFactory = new SqlConnectionFactory(ConfigurationManager.ConnectionStrings["pochela"].ConnectionString);
		}

		public QueryProducts(IConnectionFactory connectionFactory)
		{
			_connectionFactory = connectionFactory;
		}

		public Product GetById<TKey>(TKey Id)
		{
			IEnumerable<Product> result;
			using (var cn = _connectionFactory.CreateConnection())
			{
				cn.Open();
				result = SqlMapper.Query<Product>(cn, "select * from products where id = ?", Id);
				cn.Close();
			}

			return result.FirstOrDefault();
		}

		public IEnumerable<Product> GetByCode(string code)
		{
			IEnumerable<Product> result;
			using (var cn = _connectionFactory.CreateConnection())
			{
				cn.Open();
				var q = "select * from products where ProductCode = ?";
				result = cn.Query<Product>(q, code);
				cn.Close();
			}

			return result.ToList();
		}
		public IEnumerable<Product> Search(string filter)
		{
			IEnumerable<Product> result;
			using (var cn = _connectionFactory.CreateConnection())
			{
				cn.Open();
				var q = "select * from products where Name like '%' + @pValue + '%' or Description like '%' + @pValue + '%'";
				result = cn.Query<Product>(q, new { pValue = filter });
				cn.Close();
			}

			return result.ToList();
		}

	}
}
