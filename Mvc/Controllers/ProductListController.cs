using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Telerik.Sitefinity.Ecommerce.Catalog.Model;
using Telerik.Sitefinity.Modules.Ecommerce.Catalog;
using Telerik.Sitefinity.Mvc;
using System.Web;


namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "ProductList", Title = "Product List", SectionName = "Blue Text")]
    public class ProductListController : Controller
    {
        // GET: Promo_3Col
        public ActionResult Index()
        {
            //Guid productId = new Guid("DC0D3C41-3EBF-4896-86B9-C3C606C7BA05");

            CatalogManager catalogManager = CatalogManager.GetManager();

            List<Product> productList = catalogManager.GetProducts().ToList();

          

            return View(productList);
        }
        public ActionResult Create()
        {
            return View();
        }

        /*public string getPrimaryImageURLByProduct(Guid productID) {
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
        }*/
    }
}

