using Pochela.POS.Db;
using Pochela.POS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pochela.POS.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		#region REST

		[HttpPost]
		public JsonResult GetProductByCode(string code)
		{
			var query = new QueryProducts();
			var result = query.Search(code);
			if (result.Count() > 0)
			{
				return Json(result, JsonRequestBehavior.AllowGet);
			}
			return Json(false, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		public JsonResult CreateProduct(Product model)
		{
			model.CreatedBy = 1;
			model.CreatedOn = DateTime.UtcNow;
			model.UnitOfMeasure = "Each";

			var cmd = new CommandProduct();
			cmd.Create(model);
			return Json(true, JsonRequestBehavior.AllowGet);
		}

		#endregion
	}
}