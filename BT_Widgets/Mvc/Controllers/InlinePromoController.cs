using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.InlinePromo;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "InlinePromo", Title = "In-line Promo", SectionName = "Blue Text")]
    public class InlinePromoController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public InlinePromoModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new InlinePromoModel();

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
                m_object.Link = m_object.Link.Replace("href=", " class=\"btn btn_border2\" href=");
            }
            return this.View("InlinePromo." + this.Template, m_object);
        }

        private InlinePromoModel model;
        private string template = "Default";
    }
}