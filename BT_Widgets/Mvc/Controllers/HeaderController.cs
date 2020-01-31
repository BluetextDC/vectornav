using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.Header;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "Header", Title = "Header", SectionName = "Blue Text")]
    public class HeaderController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public HeaderModel Model
        {
            get
            {
                if (this.model == null)
                {
                    this.model = new HeaderModel();
                    
                }

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
            return this.View("Header." + this.Template, m_object);
        }

        private HeaderModel model;
        private string template = "Default";
    }
}