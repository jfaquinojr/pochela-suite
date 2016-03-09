using AutoMapper;
using Pochela.Infrastructure;
using Pochela.Inventory.Entities;
using Pochela.Inventory.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.Inventory.Facade
{
    public class InventoryService : IInventoryService
    {
		IQueryRepository<Product> _dbQuery;
		public InventoryService()
		{
			_dbQuery = new ProductQuery();
		}

		public InventoryService(IQueryRepository<Product> dbQuery)
		{
			_dbQuery = dbQuery;
		}

		public IEnumerable<Product> SearchProducts(string criteria)
		{
			var list = _dbQuery.Search(criteria);

			Mapper.CreateMap<Product, Entities.Product>();
			var ret = Mapper.Map<IEnumerable<Product>, IEnumerable<Entities.Product>>(list);


			return ret;
		}
    }
}
