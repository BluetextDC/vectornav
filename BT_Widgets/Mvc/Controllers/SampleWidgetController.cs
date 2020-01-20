using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.SampleWidget;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "SampleWidget", Title = "Sample-Widget", SectionName = "Test_BT")]
    public class SampleWidgetController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public SampleWidgetModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new SampleWidgetModel();

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
            if (m_object.Link != null && m_object.Link.Trim().Length > 0)
            {
                m_object.Link = m_object.Link.Replace("href=", " class=\"btn btn_border3\" href=");
            }
            return this.View("SampleWidget." + this.Template, m_object);
        }

        private SampleWidgetModel model;
        private string template = "Default";
    }
}
