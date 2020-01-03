using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Ecommerce.Catalog.Model;
using Telerik.Sitefinity.Modules.Ecommerce.Catalog;

namespace SitefinityWebApp.Mvc.Controllers
{
   // [ControllerToolboxItem(Name = "ProductDetail", Title = "Product Detail", SectionName = "Blue Text")]
    public class ProductDetailController : Controller
    {
        // GET: Temp
        public ActionResult Index()
        {
            string id = Request.QueryString["id"];

            //Guid productId = new Guid("DC0D3C41-3EBF-4896-86B9-C3C606C7BA05");

            Guid productId = new Guid(id);

            CatalogManager catalogManager = CatalogManager.GetManager();

             Product product = catalogManager.GetProduct(productId);


            return View(product);
        }

        public string getPrimaryImageURLByProduct(Guid productID) {
           string primaryImageURL = String.Empty;
           // Get a Catalog Manager
           CatalogManager manager = CatalogManager.GetManager();

           // Pull back your product
           Product product = manager.GetProducts().Where(p => p.Id == productID).FirstOrDefault();
           if (product != null) {
               IEnumerable<Product> productWithImages = manager.PopulateImages("", Enumerable.Repeat<Product>(product, 1));

               foreach (Product p in productWithImages) { 

                   // Grab the URL to the primary image for this product
                   primaryImageURL = p.PrimaryImageUrl;
               }
           }

           return primaryImageURL;
        }

    }
}
