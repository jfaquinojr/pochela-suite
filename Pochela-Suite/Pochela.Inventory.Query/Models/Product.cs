using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.Inventory.Query.Models
{
	public class Product
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public string ProductNumber { get; set; }
		public string Color { get; set; }
		public int SafetyStockLevel { get; set; }
		public double StandardCost { get; set; }
		public double ListPrice { get; set; }
	}
}
