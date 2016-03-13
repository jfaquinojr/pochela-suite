using Dapper;
using Pochela.Infrastructure;
using Pochela.POS.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.POS.Db
{
	public class CommandProduct : ICommandRepository<Product>
	{
		IConnectionFactory _connectionFactory;

		public CommandProduct()
		{
			_connectionFactory = new SqlConnectionFactory(ConfigurationManager.ConnectionStrings["pochela"].ConnectionString);
		}

		public CommandProduct(IConnectionFactory connectionFactory)
		{
			_connectionFactory = connectionFactory;
		}

		public void Create(Product model)
		{
			var sql = "insert into dbo.Products(Name,Description,ProductCode,UnitOfMeasure,UnitPrice,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn)\n";
			sql += "values(@Name, @Description, @ProductCode, @UnitOfMeasure, @UnitPrice, @CreatedBy, @CreatedOn, @ModifiedBy, @ModifiedOn)";
			using (var cn = _connectionFactory.CreateConnection())
			{
				cn.Open();
				cn.Execute(sql, model);
				cn.Close();
			};
		}

		public void Delete(Product model)
		{
			var sql = "delete from dbo.Products where ID = @ID";
			using (var cn = _connectionFactory.CreateConnection())
			{
				cn.Open();
				cn.Execute(sql, model);
				cn.Close();
			};
		}

		public void Save(Product model)
		{
			throw new NotImplementedException();
		}
	}
}
