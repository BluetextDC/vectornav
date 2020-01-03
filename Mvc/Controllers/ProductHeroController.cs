using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Telerik.Sitefinity.Ecommerce.Catalog.Model;
using Telerik.Sitefinity.Modules.Ecommerce.Catalog;
using Telerik.Sitefinity.Mvc;

using Telerik.Sitefinity.Model;

using System.Web;


namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "bt_ProductHero", Title = "Product Hero", SectionName = "Blue Text")]
    public class ProductHeroController : Controller
    {
        // GET: ProductHero
        public ActionResult Index()
        {
            string id = Request.QueryString["id"];
            Guid productId=  new Guid(id) ;

            CatalogManager catalogManager = CatalogManager.GetManager();

            Product product = catalogManager.GetProduct(productId);


            //if (product.GetValue("GynoRange") != null)

           //  Product product = catalogManager.GetProducts().Where(m=> m.Title == "VN-100 IMU/AHRS" && m.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live).FirstOrDefault();
            ViewBag.GyroRange = Convert.ToDouble(product.GetValue("GyroRange"));
            ViewBag.GyroBios = Convert.ToDouble(product.GetValue("GyroBios"));
            ViewBag.AngularWalk = Convert.ToDouble(product.GetValue("AngularWalk"));
            ViewBag.AccelRange = Convert.ToDouble(product.GetValue("AccelRange"));
            ViewBag.AccelBios = Convert.ToDouble(product.GetValue("AccelBios"));
            ViewBag.VelocityWalk = Convert.ToDouble(product.GetValue("VelocityWalk"));
            ViewBag.DocumentURL = Convert.ToString(product.GetValue("DocumentURL"));


            // return product;

            //Telerik.Sitefinity.Ecommerce.Catalog.Model.Product objProduct = new Telerik.Sitefinity.Ecommerce.Catalog.Model.Product();

            return View(product);
            
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}