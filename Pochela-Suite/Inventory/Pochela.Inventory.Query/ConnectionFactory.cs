using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.Inventory.Query
{
	public interface IConnectionFactory
	{
		IDbConnection CreateConnection();
	}

	public class SqlConnectionFactory : IConnectionFactory
	{
		string _connectionString;
		public SqlConnectionFactory(string connectionString)
		{
			_connectionString = connectionString;
		}

		public IDbConnection CreateConnection()
		{
			return new SqlConnection(_connectionString);
		}
	}
}
