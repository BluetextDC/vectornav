
using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.TabbedListingContent;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "TabbedListingContent", Title = "Tabbed Listing Content", SectionName = "Test_BT")]
    public class TabbedListingContentController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public TabbedListingContentModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new TabbedListingContentModel();

                return this.model;
            }
        }

        public string Template
        {
            get { return this.template; }
            set { this.template = value; }
        }

        public ActionResult Index()
        {

            var m_object = this.Model.GetViewModel();
           
            return this.View("TabbedListingContent." + this.Template, m_object);
        }

        private TabbedListingContentModel model;
        private string template = "Default";
    }
}
