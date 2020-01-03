using SitefinityWebApp.Mvc.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Personalization;

namespace SitefinityWebApp.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "GenericHero", Title = "Generic Hero", SectionName = "Blue Text")]
	public class GenericHeroController : Controller
	{
		// GET: BT_Test
		public ActionResult Index()
		{
			//var model = new BTTestModel();
			//model.Message = "Haresh";
			//model.Message1 = "Jaypal";
			//return View(model);
			return View();
		}

		//protected override void HandleUnknownAction(string actionName)
		//{
		//    this.ActionInvoker.InvokeAction(this.ControllerContext, "Index");
		//}

		public string Message { get; set; }
		public string Message12 { get; set; }
	}
}







