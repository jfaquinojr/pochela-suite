using Pochela.Inventory.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pochela.Inventory.UI.Controllers
{
    public class ProductsController : BaseController
    {
		IInventoryService _svcInventory;

		public ProductsController()
		{
			_svcInventory = new InventoryService();
		}

		public ProductsController(IInventoryService svcInventory)
		{
			_svcInventory = svcInventory;
		}

        public ActionResult Index()
        {
			var products = _svcInventory.SearchProducts("");
            return View(products);
        }

		#region REST

		public JsonResult GetAll(string filter)
		{
			var result = _svcInventory.SearchProducts(filter);

			return Json(result, JsonRequestBehavior.AllowGet);
		}

		#endregion
	}
}