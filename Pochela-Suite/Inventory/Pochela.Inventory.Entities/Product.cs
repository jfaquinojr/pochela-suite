using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.Inventory.Entities
{
	public class Product
	{
		public string ProductId { get; set; }
		public string Name { get; set; }
		public string ProductNumber { get; set; }
		public string MakeFlag { get; set; }
		public string FinishedGoodsFlag { get; set; }
		public string Color { get; set; }
		public string SafetyStockLevel { get; set; }
		public string ReorderPoint { get; set; }
		public string StandardCost { get; set; }
		public string ListPrice { get; set; }
		public string Size { get; set; }
		public string SizeUnitMeasureCode { get; set; }
		public string WeightUnitMeasureCode { get; set; }
		public string Weight { get; set; }
		public string DaysToManufacture { get; set; }
		public string ProductLine { get; set; }
		public string @Class { get; set; }
		public string Style { get; set; }
		public string ProductSubcategoryID { get; set; }
		public string ProductModelID { get; set; }
		public string SellStartDate { get; set; }
		public string SellEndDate { get; set; }
		public string DiscontinuedDate { get; set; }
		public string rowguid { get; set; }
		public string ModifiedDate { get; set; }
	}
}
