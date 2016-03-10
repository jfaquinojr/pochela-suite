using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.Inventory.Facade
{
	public interface IInventoryService
	{
		IEnumerable<Entities.Product> SearchProducts(string criteria);
	}
}
