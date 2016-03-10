using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.Inventory.Query.Mapper
{
	public class ProductionSchemaMapper<T> : AutoClassMapper<T> where T : class
	{
		public ProductionSchemaMapper() : base()
		{
			Schema("Production");
		}
	}
}
