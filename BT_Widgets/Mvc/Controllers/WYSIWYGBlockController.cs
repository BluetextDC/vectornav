using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.WYSIWYGBlock;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "WYSIWYGBlock", Title = "WYSIWYG Block", SectionName = "Blue Text")]
    public class WYSIWYGBlockController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public WYSIWYGBlockModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new WYSIWYGBlockModel();

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
           
            return this.View("WYSIWYGBlock." + this.Template, m_object);
        }

        private WYSIWYGBlockModel model;
        private string template = "Default";
    }
}
