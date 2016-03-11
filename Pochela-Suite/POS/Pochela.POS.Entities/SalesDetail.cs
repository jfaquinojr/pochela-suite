using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochela.POS.Entities
{
	public class SalesDetail
	{
		public int ID { get; set; }
		public int SalesHeaderID { get; set; }
		public int ProductID { get; set; }
		public int Quantity { get; set; }
		public double UnitPrice { get; set; }
	}
}
