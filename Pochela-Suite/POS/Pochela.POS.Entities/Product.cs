using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.POS.Entities
{
	public class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ProductCode { get; set; }
		public string UnitOfMeasure { get; set; }
		public double UnitPrice { get; set; }
		public int CreatedBy { get; set; }
		public DateTime CreatedOn { get; set; }
		public int? ModifiedBy { get; set; }
		public DateTime? ModifiedOn { get; set; }
	}
}
