using SitefinityWebApp.Mvc.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Personalization;

namespace SitefinityWebApp.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "FullWidthFiftyFiftyCarousel", Title = "Full Width 50/50 Carousel", SectionName = "Blue Text")]
	public class FullWidthFiftyFiftyCarouselController : Controller
	{
		// GET: BT_Test
		public ActionResult Index()
		{
			var model = new FullWidthFiftyFiftyCarouselModel();
			model.Content1 = Content1;
			model.Content2 = Content2;
			model.Content3 = Content3;
			model.Content4 = Content4;
			model.Content5 = Content5;
			//model.Message1 = "Jaypal";
			return View(model);
			//return View();
		}

		//protected override void HandleUnknownAction(string actionName)
		//{
		//    this.ActionInvoker.InvokeAction(this.ControllerContext, "Index");
		//}

		public string Content1 { get; set; }
		public string Content2 { get; set; }
		public string Content3 { get; set; }
		public string Content4 { get; set; }
		public string Content5 { get; set; }
	}
}